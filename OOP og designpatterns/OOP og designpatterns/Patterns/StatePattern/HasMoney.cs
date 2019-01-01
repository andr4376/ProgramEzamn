using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class HasMoney : FoodDispenserState
    {
        FoodDispenserMachine machine;

        public HasMoney(FoodDispenserMachine _machine)
        {
            machine = _machine;
        }


        public void EjectMoney()
        {
            Console.WriteLine("$" + machine.moneyInserted + " Ejected");

            machine.moneyInserted = 0;


            machine.currentState = machine.noMoneyInserted;
        }

        public void InsertMoney(int moneyAmount)
        {
            machine.moneyInserted += moneyAmount;
        }

        public void PickItem(int itemNumber)
        {
            // if the customer can afford the item, 
            if (machine.moneyInserted >= ((itemNumber +1) *3))
            {
                if (itemNumber < machine.stock.Length && machine.stock[itemNumber] != null)//and the item is not sold out
                {

                    //subtract money
                    machine.moneyInserted -= ((itemNumber + 1) * 3);

                    //dispense item
                    Console.WriteLine("Dispensing item: " + machine.stock[itemNumber]);
                    machine.stock[itemNumber] = null;

                    if (OutOfStock())
                    {
                        EjectMoney();
                        Console.WriteLine("Machine is out of stock");
                        machine.currentState = machine.outOfStock;
                        return;
                    }

                    //if there is no money left
                    if (machine.moneyInserted <= 0)
                    {
                        Console.WriteLine("Machine is out of stock");
                        machine.currentState = machine.noMoneyInserted;
                        return;

                    }

                    //waiting for new costumers
                }
                else
                {
                    Console.WriteLine("Item Unavaiable");

                    if (OutOfStock())
                    {
                        machine.currentState = machine.outOfStock;
                        return;
                    }

                }
            }
            else
            {
                Console.WriteLine("Not enough money for that item");
            }

        }

        private bool OutOfStock()
        {
            foreach (string item in machine.stock)
            {
                if (item != null)
                {
                    return false; //if there are any items, it's not out of stock
                }
            }

            return true;
        }
    }
}
