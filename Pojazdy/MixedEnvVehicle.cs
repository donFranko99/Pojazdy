using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public class MixedEnvVehicle:BaseVehicle
    {
        private Environment currentEnvironment;
        private string nativeAltVelocityUnit;
        public double MaxAltVelocity { get; }
        public double MinAltVelocity { get; }
        public string NativeAltVelocityUnit { get => nativeAltVelocityUnit; }
        public int NumberOfWheels { get; }
        public double Displacement { get; }
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
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.AppendLine($"Alternative environment");
            if (NumberOfWheels != 0)
                s.AppendLine($"Number of wheels: {NumberOfWheels}");
            if (Displacement != 0)
                s.AppendLine($"Displacement: {Displacement} tons");
            return s.ToString();
        }
        public MixedEnvVehicle(string name, Environment environment, Environment alternateEnvironment, int numberOfWheels=0, double displacement=0, Engine engine = null) : base(name, engine, environment)
        {
            AlternateEnvironment = alternateEnvironment;
            Displacement = displacement;
            NumberOfWheels = numberOfWheels;
            if (engine != null && (environment==Environment.Water || alternateEnvironment==Environment.Water))
            {
                this.Engine.Type = Engine.EngineType.Diesel;
            }
            switch (alternateEnvironment)
            {
                case Environment.Air:
                    MinAltVelocity = 20;
                    MaxAltVelocity = 200;
                    nativeAltVelocityUnit = "m/s";
                    break;
                case Environment.Water:
                    MinAltVelocity = 1;
                    MaxAltVelocity = 40;
                    nativeAltVelocityUnit = "knots";
                    break;
                case Environment.Ground:
                    MinAltVelocity = 1;
                    MaxAltVelocity = 350;
                    nativeAltVelocityUnit = "km/h";
                    break;
                default:
                    break;
            }
        }

    }
}
