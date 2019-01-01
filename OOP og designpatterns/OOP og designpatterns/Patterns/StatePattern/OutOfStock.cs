using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class OutOfStock : FoodDispenserState
    {

        FoodDispenserMachine machine;

        public OutOfStock(FoodDispenserMachine _machine)
        {
            machine = _machine;
        }

        public void EjectMoney()
        {
            if (machine.moneyInserted > 0)
            {
                Console.WriteLine("$"+ machine.moneyInserted+" Ejected");
                machine.moneyInserted = 0;
                return;
            }
            Console.WriteLine("There is no money to be returned");
        }

        public void InsertMoney(int moneyAmount)
        {
            machine.moneyInserted += moneyAmount;

            Console.WriteLine("We're out of stock");

            EjectMoney();
        }

        public void PickItem(int itemNumber)
        {
            Console.WriteLine("We're out of stock");

            if (machine.moneyInserted > 0)
            {
                EjectMoney();
            }
        }
    }
}
