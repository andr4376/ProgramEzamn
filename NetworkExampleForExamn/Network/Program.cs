using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Network
{
    class Program
    {
        static void Main(string[] args)
        {


            //new Thread(() => UDPBroadCastingServer.ListenForMessage()) { IsBackground = true }.Start();


            //for (int i = 0; i < 10000; i++)
            //{
            //    UDPBroadCastingServer.information.Enqueue("message #" + i);
            //    Thread.Sleep(100);
            //}
            //Console.ReadKey();

            new Thread(() => UDPServerExample.ServerUpdate()) { IsBackground = true }.Start();



            Console.ReadKey();

            TCPServerExample.Instance.ToString();

            Console.ReadKey();
        }
    }
}
