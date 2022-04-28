using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class Engine
    {
        public int BreakHorsePower { get; set; }
        public EngineType Type;
        public Engine(EngineType type, int bhp)
        {
            this.Type = type;
            this.BreakHorsePower = bhp;
        }
        public enum EngineType
        {
            Petrol,
            Diesel,
            LPG,
            Electric,
            Steam,
            Hybrid
        }
    }
}
