using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ObserverPattern
    {
        public Action Event; //the event an object should subscribe to

        public void ActivateEvent()
        {            
                Event();            

        }
    }

    class Player
    {
        public string name;

        public Player(ObserverPattern observerPattern, string _name)
        {
            name = _name;

            //Add method that should be executed when die event is invoked
            observerPattern.Event += MethodToCallWhenEventHappens;
        }

        private void MethodToCallWhenEventHappens()
        {
            Console.WriteLine("Player {0} knows the event has happened!",name);
        }
    }

    static class TestObserverPattern
    {
        public static void Test()
        {
            ObserverPattern eventSystem = new ObserverPattern();


            for (int i = 1; i <= 10; i++)
            {
                new Player(eventSystem, "Player " + i);
            }

            Console.WriteLine("Make 10 players");
            Console.WriteLine("Waiting for 3 seconds before invoking method");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Event activated!\n");
            eventSystem.ActivateEvent();


            Console.ReadKey();

        }
    }

}
