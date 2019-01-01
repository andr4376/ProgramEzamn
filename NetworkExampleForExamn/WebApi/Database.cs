using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi
{
    public class Database
    {

        private static List<Dog> dogs;

        public static List<Dog> Dogs
        {
            get
            {
                if (dogs == null)
                {
                    InitializeDogList();
                }

                return dogs;
            }
            set
            {
                dogs = value;
            }
        }


        public static void InitializeDogList()
        {
            //Dummy list - normally read from database file
            dogs = new List<Dog>();
            dogs.Add(new Dog() { ID = 1, Name = "Charlie", Race = "Collie" });
            dogs.Add(new Dog() { ID = 2, Name = "Basse", Race = "Labrador" });
            dogs.Add(new Dog() { ID = 3, Name = "Bongo", Race = "Brun Labrador" });

        }


    }
}