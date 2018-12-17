using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_og_kvalitetssikring
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
             how to make unit tests:
             
            add new project to solution "Unit tests Project (.Net Framework)"

            make a reference to the solution you want to test

            use namespace in test project
             */

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            FakeClass.ConvertIntToByte(256);
            Console.ReadKey();
        }
    }
}
