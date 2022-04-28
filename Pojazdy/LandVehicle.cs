using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class LandVehicle : BaseVehicle
    {
        public LandVehicle(string name, double minVelocity = 1, double maxVelocity = 350, Environment environment = Environment.Ground, Engine engine = null) : base(name, minVelocity, maxVelocity, environment, engine){}
    }
}
