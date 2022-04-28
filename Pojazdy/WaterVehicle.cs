using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class WaterVehicle : BaseVehicle
    {
        public double Displacement { get; }
        public WaterVehicle(string name, double displacement, double minVelocity = 1, double maxVelocity = 40, Environment environment = Environment.Water, Engine engine = null) : base(name, minVelocity, maxVelocity, environment, engine)
        {
            Displacement = displacement;
            if (engine!=null)
            {
                this.Engine.Type = Engine.EngineType.Diesel;
            }
        }
    }
}
