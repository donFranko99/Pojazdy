using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{

    public interface IVehicle
    {
        public void StartStop();
        public double VelocityUniversalValue();
        public void ChangeVelocity(double acceleration);

        public static double CalculateSpeed(double currentVelocity, Environment baseEnv, Environment targetEnv)
        {
            switch (baseEnv)
            {
                case Environment.Air:
                    {
                        switch (targetEnv)
                        {
                            case Environment.Air:
                                return currentVelocity*1.944;
                            case Environment.Water:
                                return currentVelocity;
                            case Environment.Ground:
                                return currentVelocity*3.6;
                            default:
                                return currentVelocity;
                        }
                    }
                case Environment.Water:
                    {
                        switch (targetEnv)
                        {
                            case Environment.Air:
                                return currentVelocity*0.514;
                            case Environment.Water:
                                return currentVelocity;
                            case Environment.Ground:
                                return currentVelocity*1.85;
                            default:
                                return currentVelocity;
                        }
                    }
                case Environment.Ground:
                    {
                        switch (targetEnv)
                        {
                            case Environment.Air:
                                return currentVelocity*0.278;
                            case Environment.Water:
                                return currentVelocity * 0.54;
                            case Environment.Ground:
                                return currentVelocity;
                            default:
                                return currentVelocity;
                        }
                    }
                default:
                    return currentVelocity;
            }
        }
    }

    public enum Environment
    { 
        Air,
        Water,
        Ground
    }
}
