using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ConcreteBuilder : IBuilder
    {
        GameObject product;

        public void Build()
        {
            product = new GameObject();
            product.AddComponent(new ComponentThatShouldDoSomething());
            product.AddComponent(new ComponentThatDoesAnotherThing());
        }

        public GameObject GetResult()
        {

            return product;
        }
    }
}
