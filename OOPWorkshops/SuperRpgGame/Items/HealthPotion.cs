using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRpgGame.Items
{
    public class HealthPotion : Item
    {
        private const char HealthPotionSymbol = 'H';
        public HealthPotion(Position position, PotionSize potionSize) : base(position, HealthPotionSymbol)
        {
            this.PotionSize = potionSize;
        }

        public PotionSize PotionSize { get; set; }
        public int HealthRestore
        {
            get { return (int)this.PotionSize; }

        }

    }
}
