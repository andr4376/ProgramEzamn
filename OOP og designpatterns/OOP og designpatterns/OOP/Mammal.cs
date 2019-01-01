using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns.OOP
{
    class Mammal : Animal
    {
        protected override void Breathe(Oxygen oxygen)
        {
            //breathe fresh air
        }

        protected override void Eat(Food food)
        {
            //eat food
        }


        protected virtual void GiveBirth()
        {
            //pop out a baby
        }
    }
}
