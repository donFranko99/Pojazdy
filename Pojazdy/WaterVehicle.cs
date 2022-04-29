using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class WaterVehicle : BaseVehicle
    {
        public double Displacement { get; }
        public WaterVehicle(string name, double displacement, Environment environment = Environment.Water, Engine engine = null) : base(name, environment, engine)
        {
            Displacement = displacement;
            if (engine!=null)
            {
                this.Engine.Type = Engine.EngineType.Diesel;
            }
            
        }
    }
}
