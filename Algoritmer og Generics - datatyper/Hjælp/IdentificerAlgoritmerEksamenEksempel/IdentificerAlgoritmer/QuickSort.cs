using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificerAlgoritmer
{
    class QuickSort
    {
        public List<T> QuickSortAlgorithm<T>(List<T> items) where T : IComparable
        {
            if (items.Count <= 1)
            {
                return items;
            }

            List<T> before = new List<T>();
            List<T> after = new List<T>();

            T pivot = items[0];

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].CompareTo(pivot) > 0)
                {
                    after.Add(items[i]);

                }
                if (items[i].CompareTo(pivot) < 0)
                {
                    before.Add(items[i]);

                }
            }

            List<T> result = new List<T>();
            result.AddRange(QuickSortAlgorithm<T>(before));
            result.Add(pivot);
            result.AddRange(QuickSortAlgorithm<T>(after));

            return result;
        }
    }
}
