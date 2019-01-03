using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPatternExamnExample
{
    class BMWBuilder : CarBuilder
    {
        public override void BuildBrand()
        {
            product.carBrand = CarBrand.BMW;
        }

        public override void BuildColor()
        {
            product.color = Color.YELLOW;
        }

        public override void BuildMotor()
        {
            product.motorType = MotorType.FASTMOTOR;
        }

        public override void BuildSeats()
        {
            product.seatAmount = 2;
        }

        public override void BuildType()
        {
            product.carType = CarType.CABRIOLET;
        }
        public override void BuildGPS()
        {
            product.gps = true;
        }
    }
}
