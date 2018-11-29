using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    /// <summary>
    /// en bestemt funktionalitet som skal kan køres. kunne være hop, skyd, skifte algoritme, 
    /// /// 
    /// </summary>
    class ConcreteStrategy2 : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy2 is doing a strategy");
        }
    }
}
