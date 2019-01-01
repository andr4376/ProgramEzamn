using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    interface FoodDispenserState
    {

        void InsertMoney(int moneyAmount);

        void PickItem(int itemNumber);

        void EjectMoney();


    }
}
