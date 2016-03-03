using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Battleships.Ships
{
    class AircraftCarrier : Battleship
    {
        private int fighterCapacity;

        public AircraftCarrier(string name, double lengthInMeters, double volume, int fighterCapacity) : base(name, lengthInMeters, volume)
        {
            this.FighterCapacity = fighterCapacity;
        }  

        public int FighterCapacity
        {
            get
            {
                return this.fighterCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The fighter capacity of an aircraft carrier cannot be negative.");
                }

                this.fighterCapacity = value;
            }
        }
        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "We bombed them from the sky!";
        }
    }
}
