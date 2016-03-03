using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Characters;

namespace SuperRpgGame.Interfaces
{
    public interface IAttack
    {
        int Damage { get; set; }
        void Attack(ICharacter enemy);
    }
}
