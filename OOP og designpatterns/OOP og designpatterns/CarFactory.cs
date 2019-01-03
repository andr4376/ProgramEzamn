using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    public enum CarBrands { VOLVO, TOYOTA, BMW }

    public static class CarFactory
    {
        public static CarType MakeCar<CarType>() where CarType : Car, new() //constraints
        {
            return new CarType(); 
        }

        public static Car MakeCar(CarBrands brand)
        {
            switch (brand)
            {
                case CarBrands.VOLVO:
                    return new Volvo();

                case CarBrands.TOYOTA:
                    return new Toyota();

                case CarBrands.BMW:
                    return new BMW();

                default:
                    return null;
            }
        }

        public static Car MakeCar(string brand)
        {
            switch (brand.ToLower())
            {
                case "volvo":
                    return new Volvo();

                case "toyota":
                    return new Toyota();

                case "bmw":
                    return new BMW();

                default:
                    return null;
            }
        }
    }
}
