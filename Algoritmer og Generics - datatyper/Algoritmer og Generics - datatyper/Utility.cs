using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    class Utility
    {
        public static bool CompareValues<T1, T2>(T1 val1, T2 val2)
        {
            //return true if value1 is the same type as value2

            return val1.Equals(val2);
        }


        public static bool CompareDataTypes<T1, T2>(T1 type1, T2 type2)
        {
            //return true if t1 is the same type as t2
            return typeof(T1).Equals(typeof(T2));
        }
    }
}
