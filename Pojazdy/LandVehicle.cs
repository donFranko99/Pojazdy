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
            StringBuilder s = null;
            s.Append(base.ToString());
            s.AppendLine($"Number of wheels: {NumberOfWheels}");
            return s.ToString();
        }
        public LandVehicle(string name, int wheels, Environment environment = Environment.Ground, Engine engine = null) : base(name, environment, engine)
        {
            NumberOfWheels = wheels;
        }
    }
}
