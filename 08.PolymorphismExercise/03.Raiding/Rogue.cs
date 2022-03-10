using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding
{
    public class Rogue : BaseHero
    {
        public const int BasePower = 80;
        public Rogue(string name)
            : base(name, BasePower)
        {
        }

        public override string CastAbility()
        {
           return $"{nameof(Rogue)} - {Name} hit for {Power} damage";
        }
    }
}
