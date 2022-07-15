using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuel, double consumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.Fuel = fuel <= tankCapacity ? fuel : 0;
            this.Consumption = consumption;
        }

        private double fuel;
        private double consumption;
        private double tankCapacity;

        public virtual double Consumption
        {
            get => this.consumption;
            internal set => this.consumption = value;
        }
        public double Fuel
        {
            get => this.fuel;
            internal set
            {
                if (this.TankCapacity >= value)
                {
                    this.fuel = value;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {value} fuel in the tank");
                }
            }
        }
        public virtual double TankCapacity
        {
            get { return this.tankCapacity; }
            internal set { this.tankCapacity = value; }
        }


        public virtual string Drive(double distance)
        {
            if (distance * this.Consumption <= this.Fuel)
            {
                this.Fuel -= distance * this.Consumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public virtual void Refuel(double amount)
        {
            if (amount > 0)
            {
                if (this.TankCapacity >= this.Fuel + amount)
                {
                    this.Fuel += amount;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {amount} fuel in the tank");
                }
            }
            else
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
        }
    }
}
