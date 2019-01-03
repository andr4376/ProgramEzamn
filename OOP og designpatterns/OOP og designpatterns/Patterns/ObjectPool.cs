using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ObjectPool
    {
        private List<GameObject> activeList = new List<GameObject>();
        private List<GameObject> inActiveList = new List<GameObject>();

        ObjectDirector objectDirector = new ObjectDirector(new GameObjectBuilder());

        public GameObject TakeFromPool()
        {
            GameObject go;

            if (inActiveList.Count > 0)
            {
                 go = inActiveList[0];

                inActiveList.Remove(go);
            }

            else
            {
                go= objectDirector.Construct();
            }

            activeList.Add(go);

            Console.WriteLine("Inactives: " + inActiveList.Count + "  Actives: " + activeList.Count);

            return go;
        }

        public void ReturnObject(GameObject go)
        {
            CleanUp(go);
        }

        private void CleanUp(GameObject go)
        {
            //reset attributes 

            activeList.Remove(go);

            inActiveList.Add(go);

            Console.WriteLine("Inactives: "+inActiveList.Count+"  Actives: "+activeList.Count);
        }

    }
}
