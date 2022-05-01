using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class AirVehicle : BaseVehicle
    {
        public override string ToString()
        {
            StringBuilder s = null;
            s.Append(base.ToString());
            return s.ToString();
        }
        public AirVehicle(string name, Environment environment, Engine engine = null) : base(name, environment, engine)
        {
        }
    }
}
