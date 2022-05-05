using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class Engine
    {
        public int BreakHorsePower { get; }
        public EngineType Type { get; set; }
        public Engine(EngineType type, int bhp)
        {
            this.Type = type;
            this.BreakHorsePower = bhp;
        }
        public override string ToString()
        {
            return $"Engine type: {Type}\nBHP: {BreakHorsePower}";
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
