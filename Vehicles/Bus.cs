using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double ConsumptionIncrease = 1.4;
        public Bus(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }
        public string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }
        public override string Drive(double distance)
        {
            if (distance * (this.Consumption + ConsumptionIncrease) <= this.Fuel)
            {
                this.Fuel -= distance * (this.Consumption + ConsumptionIncrease);
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }
    }
}
