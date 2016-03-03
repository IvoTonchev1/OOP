using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires.Models.Units
{
    public abstract class Unit : IUnit
    {
        protected Unit(int attackDamage, int health)
        {
            this.AttackDamage = attackDamage;
            this.Health = health;
        }

        public int AttackDamage { get; private set; }
        public int Health { get; private set; }
    }
}
