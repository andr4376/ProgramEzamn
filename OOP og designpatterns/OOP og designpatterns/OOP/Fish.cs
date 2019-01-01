using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns.OOP
{
    class Fish : Animal
    {
        protected override void Breathe(Oxygen oxygen)
        {
            //breathe in water
        }

        protected override void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
