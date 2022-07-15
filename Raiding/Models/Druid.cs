using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {

        private const int DefaultPower = 80;

        public Druid(string name, int power = DefaultPower) : base(name, power)
        {
        }

        
    }
}
