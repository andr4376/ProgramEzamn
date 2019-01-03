using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificerAlgoritmer
{
    class InsertionSort
    {
        public List<T> InsertionSortAlgorithm<T>(List<T> items) where T : IComparable
        {
            List<T> listToSort = items;


            for (int i = 0; i < listToSort.Count - 1; i++)//outer loop
            {
                for (int pointer = i + 1; pointer > 0; pointer--)
                {
                    //inspect the item to the "left / above"
                    if (pointer > 0 && listToSort[pointer - 1].CompareTo(listToSort[pointer]) > 0) //if it's bigger than the number we're looking at
                    {
                        //swap them (move the item we're looking at down)
                        T temp = listToSort[pointer - 1];

                        listToSort[pointer - 1] = listToSort[pointer];
                        listToSort[pointer] = temp;

                    }
                }
            }
            return listToSort;
        }
        public List<T> InsertionSortAlgorithm2<T>(List<T> list) where T : IComparable
        {
            List<T> s = list;


            for (int i = 1; i < s.Count  ; i++) //outer loop
            {

                T insertionValue = s[i];
                int pointer = i;

                while (pointer > 0 && insertionValue.CompareTo(s[pointer - 1]) < 0)
                {

                    //swap them (move the item we're looking at down)

                    s[pointer] = s[pointer - 1];
                    pointer = pointer - 1;
                    s[pointer] = insertionValue;

                }


            }
            return s;
        }
    }
}
