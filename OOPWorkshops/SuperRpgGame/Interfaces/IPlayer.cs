using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Characters;

namespace SuperRpgGame.Interfaces
{
    public interface IPlayer : ICharacter, IMoveable, IHeal, ICollect
    {
        PlayerRace Race { get; }
    }
}
