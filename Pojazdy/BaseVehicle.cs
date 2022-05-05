using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public abstract class BaseVehicle : IVehicle
    {
        private string name;
        private bool isMoving;
        private double currentVelocity;
        private string nativeVelocityUnit;
        public string Name { get => name; }
        public string IsMoving 
        { 
            get
            {
                if (isMoving)
                {
                    return "moving";
                }
                return "not moving";
            } 
        }
        public double CurrentVelocity { get => currentVelocity; }
        public double MinVelocity { get; }
        public double MaxVelocity { get; }
        public string NativeVelocityUnit { get => nativeVelocityUnit; }
        public Environment Environment { get; }
        public Engine Engine { get; }
        public void StartStop()
        {
            if (isMoving)
            {
                currentVelocity = 0;
                Console.WriteLine($"Vehicle {Name} stopped");
            }
            else
            {
                currentVelocity = MinVelocity;
                Console.WriteLine($"Vehicle {Name} started\nCurrent velocity: {currentVelocity} {nativeVelocityUnit}");
            }
            isMoving = !isMoving;
        }
        public void ChangeVelocity(double acceleration)
        {
            currentVelocity += acceleration;
            if (currentVelocity > MaxVelocity)
                currentVelocity = MaxVelocity;
            if (currentVelocity < MinVelocity)
                currentVelocity = MinVelocity;
        }
        public double VelocityUniversalValue()
        {
            return IVehicle.CalculateSpeed(CurrentVelocity , Environment, Environment.Ground);
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"Vehicle: {name}");
            s.AppendLine($"Current Environment: {Environment}");
            s.AppendLine($"Current state: {IsMoving}");
            s.AppendLine($"Max velocity in this environment: {MaxVelocity}\nMin velocity in this environment: {MinVelocity}");
            s.AppendLine($"Current velocity: {CurrentVelocity}");
            if (Engine!=null)
                s.AppendLine(Engine.ToString());
            return s.ToString();
        }
        public BaseVehicle(string name, Engine engine = null, Environment environment=Environment.Ground)
        {
            this.name = name;
            this.Environment = environment;
            this.Engine = engine;
            switch (environment)
            {
                case Environment.Air:
                    MinVelocity = 20;  //Pojazdy powietrzne to tez drony czy helikoptery. Wydaje mi sie, ze w przypadku tych typowo powietrznych pojazdow
                    MaxVelocity = 200; //wyzsza minimalna predkosc nie wydaje sie byc logicznie poprawna.
                    nativeVelocityUnit = "m/s";
                    break;
                case Environment.Water:
                    MinVelocity = 1;
                    MaxVelocity = 40;
                    nativeVelocityUnit = "knots";
                    break;
                case Environment.Ground:
                    MinVelocity = 1;
                    MaxVelocity = 350;
                    nativeVelocityUnit = "km/h";
                    break;
                default:
                    break;
            }
        }
    }
}
