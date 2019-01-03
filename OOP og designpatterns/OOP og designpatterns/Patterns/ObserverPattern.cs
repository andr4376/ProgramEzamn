using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class ObserverPattern
    {
        #region firstExample
        public Action Event; //the event an object should subscribe to      

        public void TriggerFirstEvent()
        {
            Event();

        }
        #endregion;

        #region SecondExample
        //using delegates
        //1 Define Delegate
        //2 Define an event based on the delegate
        //3 Raise the event
        public delegate void SecondEventHandler(object source, EventArgs additionalArgumants);//1

        public event SecondEventHandler ThingHasHappened; //2

        protected virtual void OnThingHasHappened()
        {
            if (ThingHasHappened != null)
            {
                ThingHasHappened.Invoke(this, EventArgs.Empty);//3
            }

        }

        public void TiggerSecondEvent()
        {
            OnThingHasHappened();
        }


       

        #endregion
    }

    class Player
    {
        public string name;

        public Player(ObserverPattern observerPattern, string _name)
        {
            name = _name;

            //Add method that should be executed when event is invoked
            observerPattern.Event += OnThingHasHappened;
        }

        private void OnThingHasHappened()
        {
            Console.WriteLine("Player {0} knows the event has happened!", name);
        }
    }
    class Player2
    {
        public string name;

        public Player2(ObserverPattern observerPattern,string _name)
        {
            name = _name;
            observerPattern.ThingHasHappened += OnThingHasHappened;
            //Add method that should be executed when die event is invoked
        }

        public void OnThingHasHappened(object source,EventArgs args)
        {
            Console.WriteLine("Player {0} knows the event has happened!", name);
        }
    }

    static class TestObserverPattern
    {
        public static void Test()
        {


            //example1:
            ObserverPattern eventSystem = new ObserverPattern();

            for (int i = 1; i <= 10; i++)
            {
                new Player(eventSystem, "Player " + i);
            }

            Console.WriteLine("Make 10 players");
            Console.WriteLine("Waiting for 3 seconds before invoking method");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Event activated!\n");
            eventSystem.TriggerFirstEvent();
            Console.ReadKey();


            //example2:
            eventSystem = new ObserverPattern();

            Console.WriteLine("Make 10 players");
            for (int i = 1; i <= 10; i++)
            {
                new Player2(eventSystem, "Player " + i);
            }

            Console.WriteLine("Waiting for 3 seconds before invoking method");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Event activated!\n");
            eventSystem.TiggerSecondEvent();
            Console.ReadKey();

        }
    }

}
