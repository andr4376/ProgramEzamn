using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ConcreteStrategy1 : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy1 is doing a strategy");

        }
    }
}
