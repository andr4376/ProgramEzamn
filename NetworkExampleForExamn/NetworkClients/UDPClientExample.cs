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


        public static void SendMessage(string text)
        {
            UdpClient client = new UdpClient();
            byte[] message = Encoding.ASCII.GetBytes(text);
            client.Send(message,message.Length, serverDestination);

            client.Close();
        }     
        
    }
}
