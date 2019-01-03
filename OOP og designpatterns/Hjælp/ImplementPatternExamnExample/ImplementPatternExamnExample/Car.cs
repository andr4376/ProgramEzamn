using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPatternExamnExample
{
    /* 
     * Bilerne skal have følgende attributter:
•	Antal sæder
•	Motor
•	Biltype: Er det en city car, cabriolet eller sports car 
•	GPS: Det skal indikeres om bilen har GPS.
•	Farve
•	Mærke

     * 
     * */

    enum CarType { CITYCAR, CABRIOLET, SPORTSCAR }
    enum MotorType { SUPERDUPERMOTOR, FASTMOTOR, BADMOTOR }
    enum CarBrand { VOLVO, TOYOTA, BMW }
    enum Color { RED, GREEN, BLUE, YELLOW }




    class Car
    {
        public CarType carType;
        public MotorType motorType;
        public CarBrand carBrand;
        public Color color;

        public int seatAmount;
        public bool gps;

       

        public override string ToString()
        {
            return carBrand.ToString() + " " + carType.ToString() + " MotorType: "
                + motorType.ToString() + " Color: " + color.ToString() + " seats: " +
                seatAmount + "  GPS: " + gps.ToString();
        }
    }


 
}
