using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public abstract class BaseHero
    {
        public string Name { get; }
        public int Power { get; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }

        protected BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public override string ToString()
        {
            return this.CastAbility();
        }
    }
}
