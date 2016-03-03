using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.WorkingWithAbstraction.Interfaces;

namespace _05.WorkingWithAbstraction.Characters
{
    public abstract class Character : IAttack
    {
        private int health;
        private int damage;
        private int mana;

        public Character(int health, int mana, int damage)
        {
            this.Health = health;
            this.Mana = mana;
            this.Damage = damage;
        }

        public int Health { get; set; }
        public int Damage { get; set; }
        public int Mana { get; set; }
        public abstract void Attack(Character target);
    }
}
