using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    public abstract class Animal
    {
        internal abstract double WeightModifier { get; }
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public abstract List<string> PrefferedFood { get; }

        public string Name { get; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract string AskForFood();
        public void Eat(int foodQuantity)
        { 
            this.FoodEaten += foodQuantity;
            this.Weight += foodQuantity * this.WeightModifier;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
