using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class GameObjectBuilder : IBuilder
    {
        GameObject product;

        public void BuildObject()
        {
            product = new GameObject();
            
        }

        public void MakeComponentA( )
        {
            product.AddComponent(new ComponentThatShouldDoSomething());
        }

        public void MakeComponentB()
        {
            product.AddComponent(new ComponentThatShouldDoSomething());
        }

        public GameObject GetResult()
        {

            return product;
        }

     
    }
}
