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

            Engine silnikBolid = new Engine(Engine.EngineType.Electric, 1000);
            LandVehicle bolid = new LandVehicle("bolid", 4, silnikBolid);

            Engine silnikHeli = new Engine(Engine.EngineType.Steam, 8);
            AirVehicle helikopter = new AirVehicle("helicopter", silnikHeli);

            Engine silnikSamochod = new Engine(Engine.EngineType.Petrol, 120);
            LandVehicle samochod = new LandVehicle("car", 4, silnikSamochod);

            MixedEnvVehicle samolot = new MixedEnvVehicle("plane", Environment.Air, Environment.Ground, 8);

            vehicles.Add(rower);
            vehicles.Add(motorowka);
            vehicles.Add(bolid);
            vehicles.Add(helikopter);
            vehicles.Add(samochod);
            vehicles.Add(samolot);

            Console.WriteLine("Initial Setup");
            foreach (BaseVehicle veh in vehicles)
            {
                Console.WriteLine(veh.ToString());
                Console.WriteLine("---------------------------------------");
            }

            rower.StartStop();
            rower.ChangeVelocity(19);
            motorowka.StartStop();
            motorowka.ChangeVelocity(4);
            bolid.StartStop();
            bolid.ChangeVelocity(299);
            helikopter.StartStop();
            samochod.StartStop();
            samochod.ChangeVelocity(99);
            samolot.StartStop();
            samolot.ChangeVelocity(150);
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("\n\nSecond setup");
            foreach (BaseVehicle veh in vehicles)
            {
                Console.WriteLine(veh.ToString());
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("\n\nShowing ground vehicles from the list:");
            foreach (BaseVehicle veh in vehicles)
            {
                if (veh.Environment==Environment.Ground)
                {
                    Console.WriteLine(veh.ToString());
                    Console.WriteLine("---------------------------------------"); 
                }
            }

            Console.WriteLine("\n\nSorting vehicles by current speed: ");
            for (int i = 0; i < vehicles.Count; i++)
            {
                for (int j = 0; j < vehicles.Count-i-1; j++)
                {
                    if (vehicles[j].VelocityUniversalValue() > vehicles[j+1].VelocityUniversalValue())
                    {
                        var tmp = vehicles[j];
                        vehicles[j] = vehicles[j+1];
                        vehicles[j+1] = tmp;
                    }
                }
            }
            foreach (BaseVehicle veh in vehicles)
            {
                Console.WriteLine(veh.ToString());
                Console.WriteLine(veh.VelocityUniversalValue());
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("\n\nSorting ground vehicles from slowest to fastest");
            
        }
    }
}
