using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tråde
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadExample threadExample = new ThreadExample();

            threadExample.TestRessourceSyncronizationWithNoSync();

            Console.ReadKey();

            threadExample.ResetCount();

            threadExample.TestRessourceSyncronizationWithSync();

            Console.ReadKey();

            threadExample.ResetCount();

            threadExample.TestRessourceSyncronizationWithSemaphore();

            Console.ReadKey();

            threadExample.ResetCount();

            threadExample.TestRessourceSyncronizationWithMutex();

            Console.ReadKey();
        }
    }
}
