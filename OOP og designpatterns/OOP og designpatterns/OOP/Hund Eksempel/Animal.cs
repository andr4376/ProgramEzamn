using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    abstract class Animal
    {
        //All animals have an age
        protected int age;

        //All animals needs oxygen
        protected abstract void Breathe(Oxygen oxygen);

        //All animals eat
        protected abstract void Eat(Food food);


    }
}
