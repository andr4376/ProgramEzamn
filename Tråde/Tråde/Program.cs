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
        }
    }
}
