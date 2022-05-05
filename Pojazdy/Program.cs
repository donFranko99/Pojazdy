using System;
using System.Collections.Generic;

namespace Pojazdy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<BaseVehicle> vehicles = new List<BaseVehicle>();

            LandVehicle rower = new LandVehicle("bicycle", 2);

            Engine silnikMotorowka = new Engine(Engine.EngineType.Diesel, 169);
            WaterVehicle motorowka = new WaterVehicle("motorboat", 10f, silnikMotorowka);

            Engine silnikHeli = new Engine(Engine.EngineType.Steam, 8);
            AirVehicle helikopter = new AirVehicle("helicopter", silnikHeli);

            MixedEnvVehicle samolot = new MixedEnvVehicle("plane", Environment.Air, Environment.Ground, 8);

            vehicles.Add(rower);
            vehicles.Add(motorowka);
            vehicles.Add(helikopter);
            vehicles.Add(samolot);

            foreach (BaseVehicle veh in vehicles)
            {
                Console.WriteLine(veh.ToString());
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
