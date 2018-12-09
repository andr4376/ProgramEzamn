using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tråde
{
    class ThreadExample
    {
        private ThreadExample instance;

        public ThreadExample Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThreadExample();
                }
                return instance;
            }
        }

        //empty objects are often used as keys for locks, because it doesn't need to have a value
        public static readonly object keyToRessource = new object();

        // fungere præcist ligesom locks, dog kræver den flere ressourcer, men virker på tværs af processor
        private static Mutex mutex = new Mutex();

        //En semafor tillader at et specificeret antal af tråde kan benytte samme ressource
        //når en er færdig, lader den en anden komme ind
        private static Semaphore semaPhore = new Semaphore(1, 6); //1 tråd må komme igennem, maks 6 tråde

        public static List<int> sharedRessourceList = new List<int>();

        public static int sharedCount = 0;

        public static Random rnd = new Random();

        public void AddToRessourceList(int num)
        {
            sharedRessourceList.Add(num);
        }



        public void IncrementSharedCountWithOutSync(object threadId)
        {
            int id = (int)threadId;

            while (sharedCount < 20)
            {
                int tmp = sharedCount;

                Thread.Sleep(rnd.Next(500));

                sharedCount = tmp + 1;

                Console.WriteLine("Thread " + id + " Count = " + sharedCount);
            }
        }
        public void IncrementSharedCount(object threadId)
        {
            int id = (int)threadId;

            while (sharedCount < 20)
            {
                lock (keyToRessource)
                {

                    int tmp = sharedCount;

                    Thread.Sleep(rnd.Next(500));

                    sharedCount = tmp + 1;

                    Console.WriteLine("Thread " + id + " Count = " + sharedCount);
                }
            }
        }

        public void TestRessourceSyncronizationWithNoSync()
        {
            for (int i = 1; i < 4; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(IncrementSharedCountWithOutSync));
                thread.Start(i);
                thread.IsBackground = true;
                Thread.Sleep(500);

            }

        }
        public void TestRessourceSyncronizationWithSync()
        {
            for (int i = 1; i < 4; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(IncrementSharedCount));
                thread.Start(i);
                thread.IsBackground = true;
                Thread.Sleep(500);

            }

        }
        public void ResetCount()
        {
            Console.Clear();
            sharedCount = 0;
        }

        public void TestRessourceSyncronizationWithSemaphore()
        {
            for (int i = 1; i < 7; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(IncrementSharedCountWithSemaphore));
                thread.Start(i);
                thread.IsBackground = true;
                Thread.Sleep(500);

            }

            semaPhore.Release(5);//allows 5 more threads to enter
        }
        public void TestRessourceSyncronizationWithMutex()
        {
            for (int i = 1; i < 7; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(IncrementSharedCountWithMutex));
                thread.Start(i);
                thread.IsBackground = true;
                Thread.Sleep(500);

            }

        }
        private void IncrementSharedCountWithSemaphore(object threadId)
        {
            int id = (int)threadId;

            while (sharedCount < 20)
            {
                semaPhore.WaitOne(); //lock start

                int tmp = sharedCount;

                Thread.Sleep(rnd.Next(500));

                sharedCount = tmp + 1;

                Console.WriteLine("Thread " + id + " Count = " + sharedCount);

                semaPhore.Release(); //lock end
            }
        }

        private void IncrementSharedCountWithMutex(object threadId)
        {
            int id = (int)threadId;

            while (sharedCount < 20)
            {
                mutex.WaitOne(); //lock start

                int tmp = sharedCount;

                Thread.Sleep(rnd.Next(500));

                sharedCount = tmp + 1;

                Console.WriteLine("Thread " + id + " Count = " + sharedCount);

                mutex.ReleaseMutex(); //lock end
            }
        }
    }
}

