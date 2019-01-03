using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class Builder
    {
        public static void Test()
        {
            //New object director, that is focusing on building a specefik product (concreteBuilder)
            ObjectDirector director = new ObjectDirector(new GameObjectBuilder());

            //Result of the directors construction of a gameobject
            GameObject go = director.Construct();

            //Evaluate go
            Console.WriteLine(go.ToString());

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
