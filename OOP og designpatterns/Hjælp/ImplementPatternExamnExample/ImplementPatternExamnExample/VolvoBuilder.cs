using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPatternExamnExample
{
    class VolvoBuilder : CarBuilder
    {
        public override void BuildBrand()
        {
            product.carBrand = CarBrand.VOLVO;
        }

        public override void BuildColor()
        {
            product.color = Color.GREEN;
        }

        public override void BuildMotor()
        {
            product.motorType = MotorType.BADMOTOR;
        }

        public override void BuildSeats()
        {
            product.seatAmount = 2;
        }

        public override void BuildType()
        {
            product.carType = CarType.CITYCAR;
        }
        public override void BuildGPS()
        {
            product.gps = false;
        }
    }
}
