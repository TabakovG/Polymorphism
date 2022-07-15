using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override List<string> PrefferedFood => new List<string>() { "Meat" };
        internal override double WeightModifier => 0.4;

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override string AskForFood()
        {
            return "Woof!";
        }
    }
}
