using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPatternExamnExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Director director = new Director(new ToyotaBuilder());

            
            Car tmp = director.Construct();

            Console.ReadKey();

        }
    }
}
