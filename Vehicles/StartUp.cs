using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main()
        {

            List<Vehicle> vehicles = new List<Vehicle>();
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            vehicles.Add(car);
            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            vehicles.Add(truck);
            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            vehicles.Add(bus);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                try
                {
                    string[] cmd = Console.ReadLine().Split(" ");
                    Vehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == cmd[1]);
                    if (cmd[0] == "Drive")
                    {
                        Console.WriteLine(vehicle.Drive(double.Parse(cmd[2])));
                    }
                    else if (cmd[0] == "Refuel")
                    {
                        vehicle.Refuel(double.Parse(cmd[2]));
                    }
                    else if (cmd[0] == "DriveEmpty")
                    {
                        if (vehicle is Bus b)
                        {
                            Console.WriteLine(b.DriveEmpty(double.Parse(cmd[2])));
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }

            }
            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
            Console.WriteLine($"Bus: {bus.Fuel:f2}");
        }
    }
}
