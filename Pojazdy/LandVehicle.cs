using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class LandVehicle : BaseVehicle
    {
        public int NumberOfWheels { get; }
        public LandVehicle(string name, int wheels, double minVelocity = 1, double maxVelocity = 350, Environment environment = Environment.Ground, Engine engine = null) : base(name, minVelocity, maxVelocity, environment, engine)
        {
            NumberOfWheels = wheels;
        }
    }
}
