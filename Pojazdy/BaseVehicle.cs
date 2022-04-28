using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public abstract class BaseVehicle : IVehicle
    {
        public string Name { get; }
        public bool IsMoving { get; }
        public double CurrentVelocity { get; }
        public double MinVelocity { get; }
        public double MaxVelocity { get; }
        public Environment Environment { get; }
        public Engine Engine { get; }
    }
}
