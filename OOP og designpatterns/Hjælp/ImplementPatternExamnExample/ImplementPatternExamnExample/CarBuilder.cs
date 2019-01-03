using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPatternExamnExample
{
    abstract class CarBuilder
    {
        protected Car product;



        public Car GetResult
        {
            get { return product; }
        }

        public CarBuilder()
        {
            product = new Car();
        }

        public abstract void BuildMotor();
        public abstract void BuildBrand();
        public abstract void BuildType();
        public abstract void BuildColor();
        public abstract void BuildSeats();
        public abstract void BuildGPS();







    }
}
