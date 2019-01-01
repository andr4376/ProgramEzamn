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
    class UDPServer
    {


       public static void ListenForMessage()
        {
            while (true)
            {

                int recv; //data amount

                byte[] data = new byte[256]; //data can store up to 256 bytes

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 1337); //listens for connections


                //stores connection from client
                Socket newSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                newSocket.Bind(endPoint); //binds any incoming connection to socket



                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 1337);

                EndPoint remoteEndPointTmp = (EndPoint)sender;

                recv = newSocket.ReceiveFrom(data, ref remoteEndPointTmp);

                string message = Encoding.ASCII.GetString(data, 0, recv);

                Console.WriteLine("Message from " + remoteEndPointTmp.ToString() + "\n" + message);

            }
        }

    }
}
