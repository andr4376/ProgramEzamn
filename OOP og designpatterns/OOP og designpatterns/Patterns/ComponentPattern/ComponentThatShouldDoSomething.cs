using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ComponentThatShouldDoSomething : DecoratorComponent, IDoSomething
    {
        public void DoSomething()
        {
            Console.WriteLine(GetType()+": I'm Doing Something!");
        }
    }
}
