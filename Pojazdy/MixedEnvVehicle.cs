using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class MixedEnvVehicle:BaseVehicle
    {
        private Environment currentEnvironment;
        public double MaxAltVelocity { get; }
        public Environment AlternateEnvironment { get; set; }
        public void SwitchCurrentEnvironment()
        {
            if (currentEnvironment==Environment)
            {
                currentEnvironment = AlternateEnvironment;
                return;
            }
            currentEnvironment = Environment;
        }

    }
}
