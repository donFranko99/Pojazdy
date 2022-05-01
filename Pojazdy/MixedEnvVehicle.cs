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
        public new double VelocityUniversalValue()
        {
            return IVehicle.CalculateSpeed(CurrentVelocity, currentEnvironment, Environment.Ground);
        }
        public MixedEnvVehicle(string name, Environment environment, Environment alternateEnvironment, Engine engine = null) : base(name, environment, engine)
        {
            AlternateEnvironment = alternateEnvironment;
            switch (alternateEnvironment)
            {
                case Environment.Air:
                    MinAltVelocity = 20;
                    MaxAltVelocity = 200;
                    break;
                case Environment.Water:
                    MinAltVelocity = 1;
                    MaxAltVelocity = 40;
                    break;
                case Environment.Ground:
                    MinAltVelocity = 1;
                    MaxAltVelocity = 350;
                    break;
                default:
                    break;
            }
        }

    }
}
