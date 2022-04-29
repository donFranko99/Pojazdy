using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class AirVehicle : BaseVehicle
    {
        public AirVehicle(string name, Environment environment = Environment.Ground, Engine engine = null) : base(name, environment, engine)
        {
        }
    }
}
