using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    static class InsertionSort
    {
        static int count = 0;

        public static List<int> SortList<T>(List<int> list)
        {
           

            List<int> listToSort = list;

            //amount of items in list determines how many loop cycles
            for (int currentLoopCycle = 0; currentLoopCycle < listToSort.Count - 1; currentLoopCycle++)//outer loop
            {
                //start from where we left off
                for (int pointer = currentLoopCycle + 1; pointer > 0; pointer--) //inner loop J (instead of while)
                {
                    //inspect the item to the "left / above"
                    if (listToSort[pointer - 1] > listToSort[pointer]) //if it's bigger than the number we're looking at
                    {
                        //swap them (move the item we're looking at down)
                        int temp = listToSort[pointer - 1];

                        listToSort[pointer - 1] = listToSort[pointer];
                        listToSort[pointer] = temp;

                        PrintCollection(listToSort);
                    }
                }
            }
            return listToSort;
        }



        public static void PrintCollection(List<int> list)
        {
            Console.Clear();

            Console.WriteLine("Actions " + count + "\n");

            foreach (var item in list)
            {
                Console.WriteLine("[" + item + "]");
            }
            Console.WriteLine("\nInsertion Sorting");
            System.Threading.Thread.Sleep(100);
            count++;
        }


        public static List<int> Test()
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



            testList = InsertionSort.SortList<int>(testList);
            return testList;
        }
    }

}
