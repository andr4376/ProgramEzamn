using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class FoodDispenserMachine
    {
        //Current state of the food dispenser
        public FoodDispenserState currentState;

        //All possible states a food dispenser can have
        public FoodDispenserState outOfStock, hasMoney, noMoneyInserted;
        

        //The content whithin the foodDispenser
        public string[] stock;

        public int moneyInserted = 0;

        public FoodDispenserMachine()
        {
            outOfStock = new OutOfStock(this);
            hasMoney = new HasMoney(this);
            noMoneyInserted = new NoMoneyInserted(this);

            currentState = noMoneyInserted;

            stock = new string[5] {
            "Candybar",
            "Mars",
            "Juice",
            "Cola",
            "Soup"};
        }


        public void InsertMoney(int money)
        {
            currentState.InsertMoney(money);
        }

        public void PickItem(int itemNumber)
        {
            currentState.PickItem(itemNumber);
        }

        public void EjectMoney()
        {
            currentState.EjectMoney();
        }


    }
}
