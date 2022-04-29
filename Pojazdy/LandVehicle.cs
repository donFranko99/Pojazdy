using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class LandVehicle : BaseVehicle
    {
        public int NumberOfWheels { get; }
        public override string ToString()
        {
            return base.ToString();
        }
        public LandVehicle(string name, int wheels, Environment environment = Environment.Ground, Engine engine = null) : base(name, environment, engine)
        {
            NumberOfWheels = wheels;
        }
    }
}
