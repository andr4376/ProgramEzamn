using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    class FindBiggestNumber
    {
        public static int FindBiggestNumberInList(List<int> list)
        {
            if (list.Count > 0)            {

                int largest = list[0];

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > largest)
                    {
                        largest = list[i];
                    }
                }


                return largest;
            }
            else
            {
                Console.WriteLine(" empty");
                return 0;
            }
        }
    }
}
