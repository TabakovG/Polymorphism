using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Animals;

namespace WildFarm.Factory
{
    public class AnimalFactory
    {
        public Models.Animals.Animal CreateAnimal(string type, string name, double weight, string attribute1, string attribute2 = null)
        {
            if (type == "Cat")
            {
                return new Cat(name, weight, attribute1, attribute2);
            }
            else if (type == "Dog")
            {
                return new Dog(name, weight, attribute1);
            }
            else if (type == "Hen")
            {
                return new Hen(name, weight, double.Parse(attribute1));
            }
            else if (type == "Mouse")
            { 
                return new Mouse(name, weight, attribute1);
            }
            else if (type == "Owl")
            {
                return new Owl(name, weight, double.Parse(attribute1));
            }
            else if (type == "Tiger")
            {
                return new Tiger(name, weight, attribute1, attribute2);
            }
            else 
            {
                throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
