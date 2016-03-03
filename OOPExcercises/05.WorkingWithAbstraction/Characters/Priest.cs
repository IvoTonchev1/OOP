using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.WorkingWithAbstraction.Interfaces;

namespace _05.WorkingWithAbstraction.Characters
{
    public class Priest : Character, IHeal
    {
        private const int DefaultPriestHealth = 125;
        private const int DefaultPriestMana = 200;
        private const int DefaultPriestDamage = 100;
        public Priest() : base(DefaultPriestHealth, DefaultPriestMana, DefaultPriestDamage)
        {            
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= this.Damage;
            this.Health += this.Damage/10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
