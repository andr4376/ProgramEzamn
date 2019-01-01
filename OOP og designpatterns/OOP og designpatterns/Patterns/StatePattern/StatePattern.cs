using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class StatePattern
    {
        static FoodDispenserMachine machine = new FoodDispenserMachine();

        public static void TestStatePattern()
        {

            while (true)
            {
                PrintMachineStatus();
                PrintHelp();
                TakeOrder(Console.ReadLine());
            }

        }

        private static void PrintHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Commands:");
            Console.WriteLine("insert (money)");
            Console.WriteLine("pick (item)");
            Console.WriteLine("eject");
            Console.WriteLine();

        }

        private static void PrintMachineStatus()
        {
            Console.WriteLine();
            Console.WriteLine("FoodDispenser");
            Console.WriteLine("current state: " + machine.currentState.ToString());
            Console.WriteLine("inserted money: $" + machine.moneyInserted);
            Console.WriteLine();
            Console.WriteLine("Stock:");

            for (int i = 0; i < machine.stock.Length; i++)
            {
                if (machine.stock[i] != null)
                {
                    Console.WriteLine(i + ": " + machine.stock[i] + "  $" + ((i + 1) * 3));
                }
            }

            Console.WriteLine();
        }

        private static void TakeOrder(string input)
        {
            Console.Clear();

            input = input.ToLower();

            if (input.Contains("pick"))
            {
                string[] tmp = input.Split(' ');

                int.TryParse(tmp[1], out int intVal);

                machine.PickItem(intVal);

                return;
            }

            else if (input.Contains("insert"))
            {
                string[] tmp = input.Split(' ');

                int.TryParse(tmp[1], out int intVal);

                if (intVal > 0) machine.InsertMoney(intVal);
                else return;

            }
            else if (input.Contains("eject"))
            {

                machine.EjectMoney();
                return;

            }
            else
            {
                Console.WriteLine("Invalid Command");
            }


        }

    }



}
