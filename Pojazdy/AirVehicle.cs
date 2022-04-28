using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class AirVehicle : BaseVehicle
    {
        public AirVehicle(string name, double minVelocity = 1, double maxVelocity = 200, Environment environment = Environment.Ground, Engine engine = null) : base(name, minVelocity, maxVelocity, environment, engine)
        {
        }
    }
}
