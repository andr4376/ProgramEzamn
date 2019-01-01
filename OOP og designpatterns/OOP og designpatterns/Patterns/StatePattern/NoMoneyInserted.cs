using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class NoMoneyInserted : FoodDispenserState
    {

        FoodDispenserMachine machine;

        public NoMoneyInserted(FoodDispenserMachine _machine)
        {
            machine = _machine;
        }

        public void EjectMoney()
        {
            Console.WriteLine("Cannot eject money. Insert money first.");
        }

        public void InsertMoney(int moneyAmount)
        {
            machine.moneyInserted += moneyAmount;

            machine.currentState = machine.hasMoney;
        }

        public void PickItem(int itemNumber)
        {
            Console.WriteLine("cannot pick item. Enter Money first");
        }
    }
}
