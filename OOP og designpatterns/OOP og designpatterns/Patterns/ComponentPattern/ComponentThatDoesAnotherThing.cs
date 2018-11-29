using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ComponentThatDoesAnotherThing: Component, IDoAnotherThing
    {
        public void DoAnotherThing()
        {
            Console.WriteLine(GetType()+": I'm Doing another thing!");
        }

     
    }
}
