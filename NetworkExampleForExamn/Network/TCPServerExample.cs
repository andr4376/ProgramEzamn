using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Network
{
    class TCPServerExample
    {

        //Server Settings / info
        public string serverIp;
        public int port;
        public bool isOnline = false;
        private static TcpListener tcpListener;

        List<TcpClient> clients;
        private static readonly object clientsKey = new object();

        private Queue<string> receivedDate;

        private static TCPServerExample instance;

        public static TCPServerExample Instance
        {
            get
            {
                if (instance != null)
                {

                    return instance;
                }
                else
                {
                    instance = new TCPServerExample();
                    return instance;
                }
            }
        }

        public TCPServerExample()
        {
            clients = new List<TcpClient>();
            receivedDate = new Queue<string>();
            port = 13001;
            StartServer();
        }

        /// <summary>
        /// Called when hosting a Lobby
        /// </summary>
        public void StartServer()
        {
            //Finds the local Ip
            serverIp = FindLocalIp();

            // starts the actual server
            if (tcpListener == null)
            {
                tcpListener = new TcpListener(IPAddress.Any, port);
                tcpListener.Start();
            }


            isOnline = true;

            StartServerThreads();

            //Prints Status and info to debug output
            Console.WriteLine("Server online status: " + isOnline);
            Console.WriteLine("IP: " + serverIp + "     Port:" + port);

        }

        private string FindLocalIp()
        {
            string output = "";


            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                //If Wifi or Ethernet and is online
                if ((networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    && networkInterface.OperationalStatus == OperationalStatus.Up)
                {

                    foreach (UnicastIPAddressInformation ip in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();

                            //Writes whether what kind of internet connection you have
                            System.Diagnostics.Debug.WriteLine("Internet type: " +
                                networkInterface.NetworkInterfaceType.ToString());
                        }
                    }
                }
            }

            if (output == "")
            {
                output = "No connection found";
            }
            return output;
        }

        private void StartServerThreads()
        {
            //a thread to handle server logic -> (could distribute received data to other clients ect.)
            Thread serverUpdateThread = new Thread(ServerUpdate)
            {
                IsBackground = true
            };
            serverUpdateThread.Start();

            //a thread to handle new clients
            Thread searchForClientsThread = new Thread(FindNewClients)
            {
                IsBackground = true
            };
            searchForClientsThread.Start();
        }

        private void ServerUpdate()
        {
            while (isOnline)
            {
                if (receivedDate.Count > 0)
                {
                    //Writes the received data in chronological order
                    Console.WriteLine(receivedDate.Dequeue());
                }
                Thread.Sleep(200);
            }
        }

        private void FindNewClients()
        {

            while (isOnline)
            {
                SearchAndAddClient();


            }
        }

        private void SearchAndAddClient()
        {
            // wait for client connection
            TcpClient newClient = tcpListener.AcceptTcpClient();

            // client found.
            lock (clientsKey)
            {
                clients.Add(newClient);
            }


            // create a thread to handle communication
            new Thread(() => ClientUpdate(newClient))
            {
                IsBackground = true
            }.Start();
        }

        public void ClientUpdate(TcpClient client)
        {
            // retrieve client from parameter passed to thread

            // sets two streams
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            bool isConnected = true;
            string sData = null;


            while (isConnected)
            {
                // reads from stream
                try
                {
                    //Reading untill data is received..
                    sData = sReader.ReadLine();
                }
                catch (Exception)
                {
                    //if client disconnects
                    isConnected = false;

                    lock (clientsKey)
                    {
                        clients.Remove(client);
                    }

                }

                //when data has arrived or client has disconnected
                if (sData != null)
                {
                    //evaluate the Data
                    EvaluateData(sData);

                }
            }
        }

        private void EvaluateData(string sData)
        {
            //Handle the data
            lock (clientsKey)
            {
                foreach (TcpClient client in clients)
                {
                    StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);

                    sWriter.WriteLine(sData);

                    sWriter.Flush();
                }
            }
            receivedDate.Enqueue(sData);
        }
    }



}
