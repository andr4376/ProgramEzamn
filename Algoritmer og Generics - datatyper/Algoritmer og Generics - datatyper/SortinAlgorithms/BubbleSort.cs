using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    static class BubbleSort
    {

        private static int actionCount;

        public static List<int> BubbleSortList<T>(List<int> list)
        {

            List<int> listToSort = list;

            int tmp = 0;

            //amount of iterations
            for (int loopAmount = 0; loopAmount < listToSort.Count; loopAmount++) 
            {
                // look through all elements
                for (int currentItem = 0; currentItem < listToSort.Count - 1; currentItem++) 
                {
                    //if current item is bigger than the next item
                    if (listToSort[currentItem] > listToSort[currentItem + 1]) 
                    {
                        //swap them
                        tmp = listToSort[currentItem + 1];
                        listToSort[currentItem + 1] = listToSort[currentItem];
                        listToSort[currentItem] = tmp;

                        PrintCollection(listToSort);

                    }
                }
            }
            actionCount = 0;

            return listToSort;
        }

        private static void PrintCollection(List<int> list)
        {
            actionCount++;
            Console.Clear();
            Console.WriteLine("Actions " + actionCount + "\n");

            foreach (var item in list)
            {
                Console.WriteLine("[" + item + "]");
            }
            Console.WriteLine("\nBubble Sorting");
            System.Threading.Thread.Sleep(100);
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
