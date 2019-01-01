using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns.OOP
{
    class Canine : Mammal, IFur
    {
        protected List<Tooth> teeth;


        public Canine()
        {
            teeth = new List<Tooth>();
        }

        protected override void Eat(Food food)
        {
            if (food is Meat)
            {
                base.Eat(food);
            }

        }

        protected void Bite()
        {

        }

        public void ShedFur() //implementing IFur 
        {
            // Shed the fur on all the nice funiture
        }
    }
}
