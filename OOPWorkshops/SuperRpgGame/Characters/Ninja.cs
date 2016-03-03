using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Attributes;

namespace SuperRpgGame.Characters
{
    [Enemy]
    public class Ninja : Character
    {
        private const int NinjaDamage = 150;
        private const int NinjaHealth = 300;
        private const char NinjaSymbol = 'N';
        public Ninja(Position position, string name)
            : base(position, NinjaSymbol, name, NinjaDamage, NinjaHealth)
        {
        }
    }
}
