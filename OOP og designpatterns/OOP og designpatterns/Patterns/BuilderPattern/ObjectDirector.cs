using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ObjectDirector
    {
        private IBuilder builder;

        public ObjectDirector(IBuilder builder)
        {
            this.builder = builder;
        }

        public GameObject Construct()
        {
            builder.Build();

            return builder.GetResult();
        }
    }
}
