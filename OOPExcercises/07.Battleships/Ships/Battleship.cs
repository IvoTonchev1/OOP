using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Battleships.Ships
{
    public abstract class Battleship : Ship, IAttack
    {
        public Battleship(string name, double lengthInMeters, double volume) : base(name, lengthInMeters, volume)
        {           
        }

        public abstract string Attack(Ship target);

        protected void DestroyShip(Ship target)
        {
            target.IsDestroyed = true;
        }
    }
}
