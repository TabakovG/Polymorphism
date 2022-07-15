namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Factory;
    using WildFarm.Models.Animals;

    public class StartUp
    {
        static void Main()
        {
            var factory = new AnimalFactory();
            List<Animal> animals = new List<Animal>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                Animal animal;
                try //try to create an animal
                {

                    string[] input = cmd.Split();
                    string type = input[0];
                    string name = input[1];
                    double weight = double.Parse(input[2]);
                    string attribute1 = input[3];


                    if (input.Length > 4)
                    {
                        string attribute2 = input[4];
                        animal = factory.CreateAnimal(type, name, weight, attribute1, attribute2);
                        animals.Add(animal);
                    }
                    else
                    {
                        animal = factory.CreateAnimal(type, name, weight, attribute1);
                        animals.Add(animal);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                try //try to feed the animal
                {
                    string[] food = Console.ReadLine().Split();
                    string foodType = food[0];
                    int foodQuantity = int.Parse(food[1]);

                    Console.WriteLine(animal.AskForFood());
                    if (!animal.PrefferedFood.Contains(foodType))
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {foodType}!");
                    }
                    else
                    {
                        animal.Eat(foodQuantity);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
