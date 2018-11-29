using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class Singleton
    {
        private static Singleton instance;

        /// <summary>
        /// Den eneste måde at tilgå singleton'en udefra, hvis der ikke eksistere en 
        /// instanciering, instanciere den et objekt.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        /// <summary>
        /// Privat så den ikke kan instancieres andre steder, end propertien
        /// </summary>
        private Singleton()
        {

        }

        public void AccessingSingletonExample()
        {
            Singleton.instance.ToString();
        }
    }
}
