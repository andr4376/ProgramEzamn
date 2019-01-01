using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetworkClients
{
    class TCPClientExample
    {
        private TcpClient client;
        private bool clientConnected;

        StreamWriter sWriter;
        StreamReader sReader;

        string ip;
        int port;


        public TCPClientExample(string _ip, int _port)
        {
            ip = _ip;
            port = _port;



        }

        public void ConnectClient()
        {
            // retrieve connect to server
            client = new TcpClient();

            bool error = false;

            try
            {
                IPAddress ipAddress;

                if (IPAddress.TryParse(ip, out ipAddress))
                {
                    client.Connect(ip, port);
                }
                Console.WriteLine("Connected");
            }
            catch (Exception)
            {
                error = true;
                Console.WriteLine("Server unavaible");
            }

            if (!error)
            {
                ClientHandler();
            }
        }

        /// <summary>
        /// This clientHandler reads from server untill interrupted
        /// </summary>
        private void ClientHandler()
        {
            // sets two streams
            sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            sReader = new StreamReader(client.GetStream(), Encoding.ASCII);


            string sData;

            clientConnected = true;

            while (clientConnected)
            {
                {
                    //Waits for server message.
                    sData = ReceiveFromHost(sReader);

                    //message is found.

                    //Apllies message to self
                    UseServerData(sData);

                }
            }
            client.Close();

        }

        /// <summary>
        /// Write to Host
        /// </summary>
        /// <param name="message"></param>
        public void SendToHost(string message)
        {
            if (sWriter != null)
            {
                sWriter.WriteLine(message);
                sWriter.Flush();
            }


        }

        private void UseServerData(string sData)
        {
            Console.WriteLine("Message received from host: " + sData);

        }

        /// <summary>
        /// Read from stream
        /// </summary>
        /// <returns></returns>
        private string ReceiveFromHost(StreamReader sReader)
        {
            string sData = string.Empty;


            try
            {
                sData = sReader.ReadLine();

            }
            catch (Exception)
            {


            }
            return sData;

        }

    }
}
