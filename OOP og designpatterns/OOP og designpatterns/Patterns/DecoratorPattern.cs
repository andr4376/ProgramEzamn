using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns.DecoratorPattern
{
    /// <summary>

    /// MainApp startup class for Structural 

    /// Decorator Design Pattern.

    /// </summary>

    class DecoratorPattern
    {

        public static void TestDecorator()
        {
            // Create a ConcreteComponent and two Decorators

            //Could have been a gun, then add silencer and sniper scope

            //The object we want to decorate (Concrete Component)
            ChristmasTree christMasTree = new ChristmasTree();

            //Firs & second decorations (decorators)
            CandyCane candyCane = new CandyCane();
            Ornament ornament = new Ornament();

            // Link decorators
            candyCane.SetComponent(christMasTree);
            ornament.SetComponent(candyCane);


            //print christmas tree description
            string christmasTreeDescription = ornament.Operation();

            Console.WriteLine(christmasTreeDescription);


            Console.ReadKey();
        }

    }


    abstract class DecoratorComponent
    {
        public abstract string Operation();
    }

    /// <summary>
    /// Concrete Component that will be decorated
    /// </summary>
    class ChristmasTree : DecoratorComponent
    {
        public bool isShiny = false;

        public override string Operation()
        {
            return "Christmas tree with following decoration: ";
        }
    }

    /// <summary>

    /// The 'Decorator' abstract class

    /// </summary>

    abstract class Decorator : DecoratorComponent

    {
        protected DecoratorComponent component;

        public void SetComponent(DecoratorComponent component)
        {
            this.component = component;
        }

        public override string Operation()
        {
            if (component != null)
            {
                return component.Operation();
            }
            return string.Empty;
        }

    }

    /// <summary>

    /// The 'ConcreteDecoratorA' class

    /// </summary>

    class CandyCane : Decorator

    {
        public override string Operation()
        {
            return base.Operation() + "Candy cane"; //looks to christmas tree in this instance
        }
    }

    /// <summary>

    /// The 'ConcreteDecoratorB' class

    /// </summary>

    class Ornament : Decorator

    {
        public override string Operation()
        {
            AddedBehavior();
            return base.Operation() + ", Ornament"; // looks to candy cane

        }

        void AddedBehavior()
        {

            Console.WriteLine("Added behaviour: The ornament is shiny!");
        }
    }
}