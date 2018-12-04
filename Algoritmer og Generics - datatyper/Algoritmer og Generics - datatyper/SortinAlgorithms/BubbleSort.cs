using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    static class BubbleSort
    {

        private static int count;

        public static List<int> BubbleSortList<T>(List<int> list)
        {

            List<int> tmp = list;

            int temp = 0;

            for (int write = 0; write < tmp.Count; write++)
            {
                for (int sort = 0; sort < tmp.Count - 1; sort++)
                {
                    if (tmp[sort] > tmp[sort + 1])
                    {
                        temp = tmp[sort + 1];
                        tmp[sort + 1] = tmp[sort];
                        tmp[sort] = temp;

                        PrintCollection(tmp);

                    }
                }
            }
            count = 0;

            return tmp;
        }

        private static void PrintCollection(List<int> list)
        {
            Console.Clear();
            Console.WriteLine("Actions " + count + "\n");

            foreach (var item in list)
            {
                Console.WriteLine("[" + item + "]");
            }
            Console.WriteLine("\nBubble Sorting");
            System.Threading.Thread.Sleep(50);
            count++;
        }

        public static void Test()
        {
            Random rnd = new Random();
            List<int> testList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(10000000));
            }
            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(100000));

            }
            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(10000));

            }
            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(1000));

            }

            for (int i = 0; i < 5; i++)
            {
                testList.Add(rnd.Next(100));
            }



            testList = BubbleSort.BubbleSortList<int>(testList);
        }
    }
}
