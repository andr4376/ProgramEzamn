using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestComponentPattern();
            Console.ReadKey();


            TestStrategyPattern();
            Console.ReadKey();

            TestBuilderPattern();
            Console.ReadKey();

            TestObjectPool();
            Console.Read();
        }

        private static void TestComponentPattern()
        {
            GameObject gameObject = new GameObject(); //gets a tranform by default

            //Brug vector2 
            gameObject.Transform.x = 5;
            gameObject.Transform.y = 10;

            //add a component that can do something
            Console.WriteLine("Component added");
            gameObject.AddComponent(new ComponentThatShouldDoSomething());
            gameObject.AddComponent(new ComponentThatDoesAnotherThing());
            
            ComponentThatShouldDoSomething tmp = gameObject.GetComponent<ComponentThatShouldDoSomething>();

            //make it do that thing
            gameObject.DoSomething();


            Console.WriteLine();
            Console.WriteLine(gameObject.ToString());
            Console.WriteLine();


        }

        private static void TestStrategyPattern()
        {
            StrategyClient client = new StrategyClient(new ConcreteStrategy1());

            client.Execute();

            client.strategy = new ConcreteStrategy2();
            client.Execute();

            Console.WriteLine();

        }

        private static void TestBuilderPattern()
        {
            //New object director, that is focusing on building a specefik product (concreteBuilder)
            ObjectDirector director = new ObjectDirector(new ConcreteBuilder());

            //Result of the directors construction of a gameobject
            GameObject go = director.Construct();

            //Evaluate go
            Console.WriteLine(go.ToString());

            Console.WriteLine();

        }

        private static void TestObjectPool()
        {
            ObjectPool pool = new ObjectPool();

            Console.WriteLine("Make Object");

            GameObject go = pool.TakeFromPool();

            Console.WriteLine(go.ToString());

            ComponentThatShouldDoSomething _comp =
                (ComponentThatShouldDoSomething)go.GetComponent("ComponentThatShouldDoSomething");

            go.RemoveComponent(_comp);

            Console.WriteLine("Removed a component");

            Console.WriteLine(go.ToString());


            Console.WriteLine("Putting object back in pool");

            pool.ReturnObject(go);

            Console.WriteLine("taking it back out without cleaning it, to prove that it is in fact the same item");

            GameObject go2 = pool.TakeFromPool();

            Console.WriteLine(go2.ToString());

            Console.WriteLine();

        }
    }


}




/*
            * FRAMEWORKS SLIDES
Formålet med forløbet er at den studerende bliver i stand til:

At forstå for hvad et framework er
At kunne gøre brug af et framework, som MonoGame eller XNA
At kunne gøre brug af designpatterns
At have kendskab til følgende creational designpatterns:

Lazy loading
Prototype
Singleton
Builder

*/
