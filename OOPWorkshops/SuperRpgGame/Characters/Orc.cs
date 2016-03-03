using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Attributes;

namespace SuperRpgGame.Characters
{
    [Enemy]
    public class Orc : Character
    {
        private const int OrcDamage = 100;
        private const int OrcHealth = 150;
        private const char OrcSymbol = 'O';
        public Orc(Position position, string name)
            : base(position, OrcSymbol, name, OrcDamage, OrcHealth)
        {
        }
    }
}
