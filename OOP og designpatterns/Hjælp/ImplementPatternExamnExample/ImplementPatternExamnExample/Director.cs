using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPatternExamnExample
{
    class Director
    {
        CarBuilder builder;

        public Director(CarBuilder _builder)
        {
            builder = _builder;
        }

        public Car Construct()
        {

            builder.BuildBrand();
            builder.BuildColor();
            builder.BuildGPS();
            builder.BuildMotor();
            builder.BuildSeats();
            builder.BuildType();

            Console.WriteLine(builder.GetResult);
            return builder.GetResult;
        }
    }
}
