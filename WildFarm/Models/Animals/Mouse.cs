using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override List<string> PrefferedFood => new List<string>() { "Fruit", "Vegetable" };
        internal override double WeightModifier => 0.1;



        public override string AskForFood()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
