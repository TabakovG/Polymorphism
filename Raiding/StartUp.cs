
namespace Raiding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Factory;
    using Raiding.Models;

    public class StartUp
    {
        static void Main()
        {
            var factory = new Factory.Factory();
            List<BaseHero> heroes = new List<BaseHero>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; heroes.Count < num; i++)
            {
                try
                {
                    string name = Console.ReadLine();
                    string type = Console.ReadLine();
                    heroes.Add(factory.CreateHero(name, type));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero);
            }
            if (heroes.Sum(x => x.Power) >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
