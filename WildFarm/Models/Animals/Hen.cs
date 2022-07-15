using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override List<string> PrefferedFood => new List<string>() { "Fruit", "Meat", "Seeds", "Vegetable"};
        internal override double WeightModifier => 0.35;


        public override string AskForFood()
        {
            return "Cluck";
        }

    }
}
