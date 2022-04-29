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
        public MixedEnvVehicle(string name, Environment environment, Environment alternateEnvironment, Engine engine = null) : base(name, environment, engine)
        {
            AlternateEnvironment = alternateEnvironment;
        }

    }
}
