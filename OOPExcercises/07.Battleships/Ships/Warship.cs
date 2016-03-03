using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Battleships.Ships
{
    public class Warship : Battleship
    {
        public Warship(string name, double lengthInMeters, double volume) : base(name, lengthInMeters, volume)
        {
        }
        
        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "Victory is ours!";
        }
    }
}
