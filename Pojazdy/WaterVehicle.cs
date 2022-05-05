using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class WaterVehicle : BaseVehicle
    {
        public double Displacement { get; }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.AppendLine($"Displacement: {Displacement} tons");
            return s.ToString();
        }
        public WaterVehicle(string name, double displacement, Engine engine = null, Environment environment = Environment.Water) : base(name, engine, environment)
        {
            Displacement = displacement;
            if (engine!=null)
            {
                this.Engine.Type = Engine.EngineType.Diesel;
            }
            
        }
    }
}
