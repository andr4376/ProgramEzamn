using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkClients
{
    static class UDPClientExample
    {

        private static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        static IPAddress ip = IPAddress.Parse("127.0.0.1");



        private static IPEndPoint serverDestination = new IPEndPoint(ip, 1337);

        static UdpClient client = new UdpClient();

        public static readonly object key = new object();


        //internal static void ListenForMessages()
        //{
        //    client.Connect(serverDestination);
        //    client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        //   // client.ExclusiveAddressUse = false; // only if you want to send/receive on same machine.
        //   // client.Client.Bind(serverDestination);

        //    while (true)
        //    {

        //        var receivedData = client.Receive(ref serverDestination);
        //        Console.WriteLine(receivedData);

        //        System.Threading.Thread.Sleep(20);
        //    }
        //    client.Close();

        //}
        public static void SendMessage(string text)
        {
            byte[] message = Encoding.ASCII.GetBytes(text);


            client.Send(message, message.Length, serverDestination);

        }

    }
}
