using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tråde
{

    class FakeClass
    {
        public static readonly object KeyThatOtherThreadNeeds = new object();

        private List<FakeClass> sharedRessource = new List<FakeClass>();

        public List<FakeClass> SharedRessource
        {
            get
            {
                lock (KeyThatOtherThreadNeeds)
                {
                    return sharedRessource;
                }
            }
            set
            {
                lock (KeyThatOtherThreadNeeds)
                {
                    sharedRessource = value;
                }
            }
        }


        private void ThreadStarvation
        {


        }

    }
}
