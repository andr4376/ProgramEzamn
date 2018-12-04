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
            count = 0;

            List<int> listToSort = list;

            for (int i = 0; i < listToSort.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (listToSort[j - 1] > listToSort[j])
                    {
                        int temp = listToSort[j - 1];
                        listToSort[j - 1] = listToSort[j];
                        listToSort[j] = temp;

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
            System.Threading.Thread.Sleep(50);
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
