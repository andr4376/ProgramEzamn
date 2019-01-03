using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Network
{
    class UDPBroadCastingServer
    {

        public static Queue<string> information = new Queue<string>();

        public static void ListenForMessage()
        {
            while (true)
            {
                UdpClient udpServer = new UdpClient(1337);

                while (true)
                {

                    // var data = udpServer.Receive(ref remoteEP); // listen on port 11000

                    if (information.Count > 0)
                    {
                        var remoteEP = new IPEndPoint(IPAddress.Broadcast, 1337);

                        byte[] message = Encoding.ASCII.GetBytes(information.Dequeue());
                        udpServer.Send(message, message.Length, remoteEP);

                    }

                    System.Threading.Thread.Sleep(20);
                }

            }
        }

    }
}
