using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override List<string> PrefferedFood => new List<string>() { "Meat" };
        internal override double WeightModifier => 1;



        public override string AskForFood()
        {
            return "ROAR!!!";
        }
    }
}
