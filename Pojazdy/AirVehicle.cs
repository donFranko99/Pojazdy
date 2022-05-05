using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class AirVehicle : BaseVehicle
    {
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            return s.ToString();
        }
        public AirVehicle(string name, Engine engine = null, Environment environment= Environment.Air) : base(name, engine, environment)
        {
        }
    }
}
