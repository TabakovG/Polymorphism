using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {

        private const double ConsumptionIncrease = 0.9;

        

        private double consumption;

        public Car(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }

        public override double Consumption
        { 
            get => this.consumption;
            internal set => this.consumption = value + ConsumptionIncrease;
        }

    }
}
