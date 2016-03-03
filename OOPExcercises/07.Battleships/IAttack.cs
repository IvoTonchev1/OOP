using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.Battleships.Ships;

namespace _07.Battleships
{
    public interface IAttack
    {
        string Attack(Ship target);
    }
}
