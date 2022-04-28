using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class Engine
    {
        public int BreakHorsePower { get; set; }
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
