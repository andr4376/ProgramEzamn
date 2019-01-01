using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns.OOP
{
    class Dog : Canine
    {
        private Food favouriteTreat;

        private DogRace race;

        public DogRace Race
        {
            get { return race; }
        }

        public Food FavouriteTreat
        {
            get { return favouriteTreat; }
        }

        public Dog(DogRace _race)
        {
            this.race = _race;
            this.favouriteTreat = new SnackBone();

        }

        /// <summary>
        /// Return a list of all Canines within the list
        /// </summary>
        /// <param name="animals">The list of animals to extract canines from</param>
        /// <returns></returns>
        public static List<Canine> GetAllCanines(List<Animal> animals)
        {
            //Collection of Canines
            List<Canine> canines = new List<Canine>();

            foreach (Animal animal in animals)
            {
                if (animal is Canine)
                {
                    canines.Add(animal as Canine);
                }
            }

            return canines; //Return all canines 
        }

        
    }
}
