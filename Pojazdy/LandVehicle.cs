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
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.AppendLine($"Number of wheels: {NumberOfWheels}");
            return s.ToString();
        }
        public LandVehicle(string name, int wheels, Engine engine = null, Environment environment = Environment.Ground) : base(name, engine, environment)
        {
            NumberOfWheels = wheels;
        }
    }
}
