using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class MixedEnvVehicle:BaseVehicle
    {
        private Environment currentEnvironment;

        public double MaxAltVelocity { get; }
        public double MinAltVelocity { get; }
        public Environment AlternateEnvironment { get; }
        public void SwitchCurrentEnvironment()
        {
            if (currentEnvironment==Environment)
            {
                currentEnvironment = AlternateEnvironment;
                return;
            }
            currentEnvironment = Environment;
        }
        public MixedEnvVehicle(string name, double minVelocity = 1, double maxVelocity = 40, double minAltVelocity = 1, double maxAltVelocity = 40, Environment environment = Environment.Ground, Environment alternateEnvironment = Environment.Water, Engine engine = null) : base(name, minVelocity, maxVelocity, environment, engine)
        {
            MinAltVelocity = minVelocity;
            MaxAltVelocity = maxVelocity;
            AlternateEnvironment = alternateEnvironment;
        }

    }
}
