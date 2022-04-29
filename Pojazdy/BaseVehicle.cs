﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pojazdy
{
    public abstract class BaseVehicle : IVehicle
    {
        private string name;
        private bool isMoving;
        private double currentVelocity;
        public string Name { get => name; }
        public bool IsMoving { get => isMoving; }
        public double CurrentVelocity { get => currentVelocity; }
        public double MinVelocity { get; }
        public double MaxVelocity { get; }
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
                Console.WriteLine($"Vehicle {Name} started\nCurrent velocity: {currentVelocity}");
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
        public BaseVehicle(string name, Environment environment, Engine engine=null)
        {
            this.name = name;
            this.Environment = environment;
            this.Engine = engine;
            switch (environment)
            {
                case Environment.Air:
                    MinVelocity = 20;
                    MaxVelocity = 200;
                    break;
                case Environment.Water:
                    MinVelocity = 1;
                    MaxVelocity = 40;
                    break;
                case Environment.Ground:
                    MinVelocity = 1;
                    MaxVelocity = 350;
                    break;
                default:
                    break;
            }
        }
    }
}
