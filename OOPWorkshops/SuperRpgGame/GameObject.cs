using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Exceptions;

namespace SuperRpgGame
{
    public abstract class GameObject
    {
        private Position position;
        private char objectSymbol;

        protected GameObject(Position position, char objectSymbol)
        {
            this.Position = position;
            this.ObjectSymbol = objectSymbol;
        }

        public Position Position
        {
            get { return this.position; }
            set
            {
                if (value.X < 0 || value.Y < 0)
                {
                    throw new ObjectOutOfBoundsException("Specified coordinates are outside the map.");
                }
                this.position = value;
            }
        }

        public char ObjectSymbol
        {
            get { return this.objectSymbol; }
            set
            {
                if (!char.IsUpper(value))
                {
                    throw new ArgumentOutOfRangeException("objectSymbol", "Object symbol must be an upper case letter.");
                }
                this.objectSymbol = value;
            }
        }
    }
}
