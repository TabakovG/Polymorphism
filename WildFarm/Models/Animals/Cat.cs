using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override List<string> PrefferedFood => new List<string>() { "Meat", "Vegetable" };

        internal override double WeightModifier => 0.3;

        public override string AskForFood()
        {
            return "Meow";
        }
    }
}
