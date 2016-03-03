using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WorkingWithAbstraction.Characters
{
    public class Mage : Character
    {
        private const int DefaultMageHealth = 100;
        private const int DefaultMageMana = 300;
        private const int DefaultMageDamage = 75;
        public Mage() : base(DefaultMageHealth, DefaultMageMana, DefaultMageDamage)
        {          
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= 2*this.Damage;
        }
    }
}
