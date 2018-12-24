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

        /// <summary>
        /// A recurssive algorithm that sorts an array based on a pivot point 
        /// </summary>
        /// <param name="array">array to sort</param>
        /// <param name="low">first element of array</param>
        /// <param name="high">pivot</param>
        /// <returns></returns>
        public static int[] quickSort(int[] array, int low, int high)
        {

            if (low < high)
            {
                //finds the index where the "high" belongs
                int pivot = Partition(array, low, high);


                if (pivot != -1)
                {
                    //sorts the left side of the pivot
                    quickSort(array, low, pivot - 1);

                    //sort the right side of the pivot
                    quickSort(array, pivot + 1, high);
                }

            }
            return array;
        }

        /// <summary>
        /// Finds the sorted placement of the pivot item 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private static int Partition(int[] array, int low, int high)
        {
            if (low > high) return -1; //if invalid partition

            //This element needs to be sorted, so everything on the left is lower, and everything on the right is higher
            int pivot = array[high];

            //for drawing
            pivotIndex = high;
            lowIndex = low;


            //the outer loop - this is the index where the pivot belongs (also called i in psuedo code)
            int leftWall = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                currentIndex = j; //for drawing
                DrawArray(array); //draws each time the current element we're looking at changes

                if (array[j] <= pivot) //if the inspected element is less than the pivot 
                {

                    leftWall++;// moves the place where pivot belongs one to the right
                    lowIndex = leftWall; //for drawing

                    //swap the inspected element(j) and the pivot placeholder(i)
                    int tmp = array[leftWall];
                    array[leftWall] = array[j];
                    array[j] = tmp;


                    PrintCollection(array);
                }
            }

            //When nothing else can be sorted, swap the pivot with pivot placeholder (leftwall / i)
            int temp = array[leftWall + 1]; //+1 because it doesn't reach the if statement above
            array[leftWall + 1] = array[high];
            array[high] = temp;

            PrintCollection(array);//draws

            //  Console.ReadKey();

            return leftWall + 1;
        }


        public static void PrintCollection(int[] array)
        {
            // System.Threading.Thread.Sleep(20);
            Console.ReadKey();

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
            System.Threading.Thread.Sleep(75);
            //Console.ReadKey();


        }
        public static int[] Test()
        {
            count = 0;

            //Random rnd = new Random();
            //List<int> testList = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    testList.Add(rnd.Next(10000000));
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    testList.Add(rnd.Next(100000));

            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    testList.Add(rnd.Next(10000));

            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    testList.Add(rnd.Next(1000));

            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    testList.Add(rnd.Next(100));
            //}


            //int[] array = new int[testList.Count - 1];

            //for (int i = 0; i < testList.Count - 1; i++)
            //{
            //    array[i] = testList[i];
            //}

            int[] array = new int[20] { 4, 73, 55, 8, 6, 3, 5, 4, 1, 15 ,
             32,65,12,45,32,123,1,0,2,3};




            array = quickSort(array, 0, array.Length - 1);

            return array;
        }
    }
}
