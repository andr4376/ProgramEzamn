using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetworkClients
{
    class Program
    {
        static void Main(string[] args)
        {
            TestUDP();

            //TestTCP();
        }

        private static void TestUDP()
        {
            //new Thread(() => UDPClientExample.ListenForMessages()) { IsBackground = true }.Start();

            while (true)
            {
                UDPClientExample.SendMessage(Console.ReadLine());


            }
        }


        private static void TestTCP()
        {
            TCPClientExample client = new TCPClientExample("127.0.0.1", 13001);

            new Thread(() => client.ConnectClient()) { IsBackground = true }.Start();


            System.Threading.Thread.Sleep(100);

            client.SendToHost("hello");
            client.SendToHost("dasdas");
            client.SendToHost("asdasdasdasdasd");
            client.SendToHost("vvvv");
            client.SendToHost("123123213");


            Console.ReadKey();
        }
    }
}
