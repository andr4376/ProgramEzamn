using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificerAlgoritmer
{
    class Program
    {
        static void Main(string[] args)
        {

            TestInsertion();
            TestQuick();


            Console.ReadKey();
        }

        static void TestQuick()
        {
            List<string> names = new List<string>() {
                "Bo","Julie","Torsten","Arne","Willy","Camilla","Ida"
            };

            QuickSort qSort = new QuickSort();
            names = qSort.QuickSortAlgorithm(names);
        }
        static void TestInsertion()
        {
            List<string> names = new List<string>() {
                "Bo","Julie","Torsten","Arne","Willy","Camilla","Ida"
            };

            InsertionSort insertion = new InsertionSort();
            names = insertion.InsertionSortAlgorithm2(names);
        }
    }
}
