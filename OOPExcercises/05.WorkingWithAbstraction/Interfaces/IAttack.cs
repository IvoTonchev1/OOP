using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using _05.WorkingWithAbstraction.Characters;

namespace _05.WorkingWithAbstraction.Interfaces
{
    public interface IAttack
    {
        void Attack(Character target);
    }
}
