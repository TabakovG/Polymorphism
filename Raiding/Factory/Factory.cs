using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Factory
{
    internal class Factory
    {
        public Factory()
        {
        }

        public BaseHero CreateHero(string name, string type)
        {
            if (type == "Druid")
            {
                return new Druid(name);
            }
            else if (type == "Paladin")
            {
                return new Paladin(name);
            }
            else if (type == "Rogue")
            {
                return new Rogue(name);
            }
            else if (type == "Warrior")
            {
                return new Warrior(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }
        }
    }
}
