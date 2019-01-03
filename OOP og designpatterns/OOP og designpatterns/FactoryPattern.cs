using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class FactoryPattern
    {
        internal static void Test()
        {
            Toyota toyota = (Toyota)CarFactory.MakeCar(CarBrands.TOYOTA); 

            Car car = CarFactory.MakeCar<Volvo>();

            BMW bmw = CarFactory.MakeCar<BMW>(); //no boxing / parsing needed


            Console.ReadKey();
        }
    }
}
