using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override List<string> PrefferedFood => new List<string>() { "Meat" };
        internal override double WeightModifier => 0.25;



        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
    }
}
