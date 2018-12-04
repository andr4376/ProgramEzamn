using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    class KeyValuePair<TKey, TValue>
    {
        public TKey key;
        public TValue value;
        

        public KeyValuePair(TKey _key, TValue _value)
        {
            key = _key;
            value = _value;
        }

        public void Print()
        {
            Console.WriteLine("Key " + key.ToString());
            Console.WriteLine("Value " + value.ToString());

        }

    }
}
