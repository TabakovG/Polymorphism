using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private const double ConsumptionIncrease = 1.6;
  

        private double consumption;

        public Truck(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }

        public override double Consumption 
        {
            get => this.consumption; 
            internal set => this.consumption = value + ConsumptionIncrease; 
        }

        public override void Refuel(double amount)
        {
            if (amount > 0)
            {
                if (this.TankCapacity >= this.Fuel + amount*0.95)
                {
                    this.Fuel += amount*0.95;
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
