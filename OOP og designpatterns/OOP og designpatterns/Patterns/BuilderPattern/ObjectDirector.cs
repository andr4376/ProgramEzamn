using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    /// <summary>
    /// The object in charge of making the right object
    /// </summary>
    class ObjectDirector
    {
        private IBuilder builder; //similar to strategy pattern

        public ObjectDirector(IBuilder builder)
        {
            this.builder = builder;
        }

        public GameObject Construct()
        {
            builder.BuildObject();
            builder.MakeComponentA();
            builder.MakeComponentB();

            return builder.GetResult();
        }
    }
}
