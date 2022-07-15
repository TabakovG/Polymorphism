using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int DefaultPower = 100;

        public Paladin(string name, int power = DefaultPower) : base(name, power)
        {
        }
    }
}
