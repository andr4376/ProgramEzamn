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

        private static int pivotIndex;
        private static int currentIndex;
        private static int lowIndex;

        public static int[] quickSort(int[] array, int low, int high)
        {

            if (low < high)
            {
                //finds the index where the "high" belongs
                int pivot = Partition(array, low, high);


                if (pivot != -1)
                {
                    //sorts the left side
                    quickSort(array, low, pivot - 1);

                    //sort the right side
                    quickSort(array, pivot + 1, high);
                }

            }
            return array;
        }

        private static int Partition(int[] array, int low, int high)
        {
            if (low > high) return -1;

            int pivot = array[high];    // element to be placed at the far right 

            // TODO: place these properly
            pivotIndex = high;
            lowIndex = low;

            int leftWall = (low - 1);

            for (int j = low; j < high; j++)
            {
                currentIndex = j;

                DrawArray(array);
                if (array[j] <= pivot)
                {
                    leftWall++;
                    lowIndex++; //for drawing
                    int tmp = array[leftWall];
                    array[leftWall] = array[j];
                    array[j] = tmp;


                    PrintCollection(array);
                }
            }


            int temp = array[leftWall + 1];
            array[leftWall + 1] = array[high];
            array[high] = temp;

            PrintCollection(array);

            return leftWall + 1;
        }

        private static void swap(int[] array, int low, int right)
        {


        }

        public static void PrintCollection(int[] array)
        {
            System.Threading.Thread.Sleep(500);
            // Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Actions " + count + "\n");



            for (int i = 0; i < array.Length; i++)
            {



                if (i == currentIndex && i == lowIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< low \"i\" & current \"j\"");

                }
                else if (i == currentIndex && i == pivotIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< low \"i\" & pivot");

                }
                else if (i == pivotIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< Pivot");

                }
                else if (i == currentIndex)
                {
                    Console.WriteLine("[" + array[i] + "]< current \"j\"");
                }
                else if (i == lowIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< low \"i\"");
                }
                else
                {
                    Console.WriteLine("[" + array[i] + "]");
                }
            }



            Console.WriteLine("\nQuick Sorting");

            count++;
        }

        private static void DrawArray(int[] array)
        {

            Console.Clear();
            Console.WriteLine("Actions " + count + "\n");

            for (int i = 0; i < array.Length; i++)
            {


                if (i == currentIndex && i == lowIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< low \"i\" & current \"j\"");

                }
                else if (i == currentIndex && i == pivotIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< low \"i\" & pivot");

                }
                else if (i == pivotIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< Pivot");

                }
                else if (i == currentIndex)
                {
                    Console.WriteLine("[" + array[i] + "]< current \"j\"");
                }
                else if (i == lowIndex)
                {
                    Console.WriteLine("[" + array[i] + "]<<< low \"i\"");
                }
                else
                {
                    Console.WriteLine("[" + array[i] + "]");
                }


            }
            Console.WriteLine("\nQuick Sorting");
            System.Threading.Thread.Sleep(200);
            //Console.ReadKey();


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

            //  int[] array = new int[10] { 7, 2, 1, 8, 6, 3, 5, 4, 1, 15 };




            array = quickSort(array, 0, array.Length - 1);

            return array;
        }
    }
}
