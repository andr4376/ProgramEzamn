using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tråde
{
    class Program
    {
        private static readonly object secondLock = new object();
        private static readonly object firstLock = new object();

        static void Main(string[] args)
        {



          




            //Test delegate
            DelegateExample.ExamineNumber(15, DelegateExample.GreaterThanTen);

            Console.ReadKey();

            Console.Clear();



            //tæller til 20 uden synkroniseringsmekanisme
            ThreadExample threadExample = new ThreadExample();

            threadExample.TestRessourceSyncronizationWithNoSync();

            Console.ReadKey();



            //tæller til 20 med Lock

            threadExample.ResetCount();

            threadExample.TestRessourceSyncronizationWithSync();

            Console.ReadKey();



            //tæller til 20 med semaphor
            //starter ud stille, men lader flere tråde tilgå ressourcen senere
            threadExample.ResetCount();

            threadExample.TestRessourceSyncronizationWithSemaphore();

            Console.ReadKey();



            //tæller til 20 med mutex

            threadExample.ResetCount();

            threadExample.TestRessourceSyncronizationWithMutex();

            Console.ReadKey();

            //Måder at starte tråde på:

            ThreadPool.QueueUserWorkItem(DeadLockExampleForThreadPool);

            Parallel.Invoke(() => DeadLockExample(), () => DeadLockExample()); // kør flere metoder sammentid

            new Thread(() => DeadLockExample()) { IsBackground = true }.Start(); //start en tråd med det samme


            Console.ReadKey();

        }
        private static void DeadLockExampleForThreadPool(object obj)
        {
            Console.WriteLine("Threapool method");
        }

        private static void DeadLockExample()
        {

            Console.Clear();
            Console.WriteLine("          Thread 1 & 2  Resources A & B");
            Console.WriteLine("Thread 1 starts thread 2 and sleeps. while it's asleep thread 2 takes ressource A and sleeps\n" +
                "Thread A wakes up and takes ressource B, and needs ressource A to continue.\n" +
                "Thread 2 wakes up and requires resscource B to continue\n" +
                "DEADLOCK HAS HAPPENED\n\n");


            new Thread(() => ThreadBTask()) { IsBackground = true }.Start();

            Thread.Sleep(250);
            Console.WriteLine("Thread 1 tries to take B");
            lock (secondLock)
            {
                Console.WriteLine("Thread 1 took B");
                Console.WriteLine("Thread 1 tries to take A");
                lock (firstLock)
                {
                    Console.WriteLine("Thread 1 took Ressource A");
                }
                Console.WriteLine("Thread 1 Released A");
            }
            Console.WriteLine("Thread 1 Released B");

            Console.WriteLine("NO DEADLOCK");
            Console.Read();
        }

        private static void ThreadBTask()
        {
            Console.WriteLine("                                       Thread 2 tries to take A");
            lock (firstLock)
            {
                Console.WriteLine("                                       Thread 2 took A");
                // Wait until we're fairly sure the first thread
                // has grabbed secondLock
                Thread.Sleep(500);
                Console.WriteLine("                                       Thread 2 tries to take B");
                lock (secondLock)
                {
                    Console.WriteLine("                                       Thread 2 took B");
                }
                Console.WriteLine("                                       Thread 2 released B");
            }
            Console.WriteLine("                                       Thread 2 released A");


            Console.WriteLine("Thread B task complete - no deadlock!");
        }
    }
}
