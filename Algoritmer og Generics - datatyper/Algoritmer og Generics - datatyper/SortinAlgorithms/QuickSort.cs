using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    class QuickSort
    {
        private static int count;

        public static int[] quickSort(int[] _array, int left, int right)
        {
            int[] array = _array;

            if (left > right || left < 0 || right < 0) return null;

            int index = partition(array, left, right);

            if (index != -1)
            {
                quickSort(array, left, index - 1);
                quickSort(array, index + 1, right);
            }

            return array;
        }

        private static int partition(int[] array, int left, int right)
        {
            if (left > right) return -1;

            int end = left;

            int pivot = array[right];    // choose last one to pivot, easy to code
            for (int i = left; i < right; i++)
            {
                if (array[i] < pivot)
                {
                    swap(array, i, end);
                    end++;

                    PrintCollection(array);
                }
            }

            swap(array, end, right);
            return end;
        }

        private static void swap(int[] array, int left, int right)
        {
            int tmp = array[left];
            array[left] = array[right];
            array[right] = tmp;
        }

        public static void PrintCollection(int[] array)
        {
            Console.Clear();
            Console.WriteLine("Actions " + count + "\n");

            foreach (var item in array)
            {
                Console.WriteLine("[" + item + "]");
            }
            Console.WriteLine("\nQuick Sorting");
            System.Threading.Thread.Sleep(50);
            count++;
        }

        public static int[] Test()
        {
            count = 0;

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


            int[] array = new int[testList.Count - 1];

            for (int i = 0; i < testList.Count - 1; i++)
            {
                array[i] = testList[i];
            }

            array = quickSort(array, 0, array.Length - 1);

            return array;
        }
    }
}
