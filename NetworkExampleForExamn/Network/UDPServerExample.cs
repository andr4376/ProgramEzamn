using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Network
{
    static class UDPServerExample
    {

        public static readonly object key = new object();
        
        private const int listenPort = 1337;
        static UdpClient listener = new UdpClient(listenPort);
        static IPEndPoint groupEndPoint = new IPEndPoint(IPAddress.Any, listenPort);

        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        public static bool shouldLoop = true;

        private static Queue<string> receivedMessages = new Queue<string>();

        private static void ListenForMessages()
        {
            try
            {

                Console.WriteLine("Waiting for broadcast");
                byte[] bytes = listener.Receive(ref groupEndPoint);

                string message = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

                string clientInfo = groupEndPoint.ToString();



                Console.WriteLine("Messages from {0} :\n {1}\n", clientInfo, message);
                lock (key)
                {
                    receivedMessages.Enqueue(string.Format("Messages from {0} :\n {1}\n", clientInfo, message));
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                shouldLoop = false;
            }

        }

       

        public static void ServerUpdate()
        {
            while (shouldLoop)
            {
                ListenForMessages();


            }
        }
    }
}
