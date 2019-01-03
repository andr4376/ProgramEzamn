using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPatternExamnExample
{
    class ToyotaBuilder : CarBuilder
    {

        public override void BuildBrand()
        {
            product.carBrand = CarBrand.TOYOTA;
        }

        public override void BuildColor()
        {
            product.color = Color.BLUE;
        }

        public override void BuildMotor()
        {
            product.motorType = MotorType.SUPERDUPERMOTOR;
        }

        public override void BuildSeats()
        {
            product.seatAmount = 4;
        }

        public override void BuildType()
        {
            product.carType = CarType.SPORTSCAR;
        }
        public override void BuildGPS()
        {
            product.gps = true;
        }
    }
}
