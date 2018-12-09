using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{

    static class Polymorphism
    {

        public static void Test()
        {


            Monkey monkey = new Monkey();

            Bird bird = new Bird();


            //birds and monkeys has an "Is-a" relationship with animal, meaning they are of type animal. A bird
            //a bird can never be a monkey tho.
            List<Animal> animals = new List<Animal>
            {
                monkey,
                bird
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine("Evaluate {0}, and make it do something", animal.GetName);
                animal.EvaluateAnimal();
                animal.DoSomething();
                Console.WriteLine();
            }

            //cannot do this-> foreach (Monkey monkey in animals) 

            foreach (Animal animal in animals)
            {
                if (animal is Monkey)
                {
                    (animal as Monkey).MethodOnlyMonkeyHas();
                }


                if (animal is Bird)
                {
                    (animal as Bird).MethodOnlyBirdHas();
                }
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// An abstract superclass, that defines what the ideas of being an animal consists of.
    /// Abstract allows a class to have abstract methods, which works like interfaces
    /// //Animal class cannot be instanciated, because it is abstract!
    ///anima is more of a concept, so we wouldnt want it to be a "physical" object
    /// </summary>
    abstract class Animal
    {
        private string name = string.Empty;

        //Protected allows the children to change the value
        //A protected member is accessible within its class and by derived class instances.
        protected string favouriteFood = string.Empty;

        protected string sound = string.Empty;

        public string GetName
        {
            get { return name; }
        }

        public Animal(string _name, string food, string _sound)
        {
            name = _name;
            favouriteFood = food;
            sound = _sound;
        }


        /// <summary>
        /// A method all inheriting children must have, and define themselves (like interfaces)
        /// </summary>
        public abstract void DoSomething();


        /// <summary>
        /// Virtual so i can make an override for it
        /// </summary>
        public virtual void EvaluateAnimal()
        {
            Console.WriteLine(name + "s  eat " + favouriteFood + " and says " + sound);
        }

    }

    class Monkey : Animal
    {
        public Monkey(string _name, string food, string _sound) : base(_name, food, _sound)
        {

        }
        public Monkey() : this("Monkey", "Bananas", "YEEEEEEEEEEEEEET") //calls standard constructor
        {

        }

        public void MethodOnlyMonkeyHas()
        {
            Console.WriteLine("im monkeying around");
        }

        public override void EvaluateAnimal()
        {
            base.EvaluateAnimal();
            Console.Write("*not actual monkey sounds*\n");
        }

        public override void DoSomething()
        {
            Console.WriteLine("monkey is doing something");
        }
    }

    class Bird : Animal
    {
        public Bird(string _name, string food, string _sound) : base(_name, food, _sound)
        {

        }
        public Bird() : this("Bird", "Seed", "pipple pupple") //calls standard constructor
        {

        }

        public void MethodOnlyBirdHas()
        {
            Console.WriteLine("Im a bird flying");
        }

        public override void DoSomething()
        {
            Console.WriteLine("bird is doing something");
        }
    }


}
