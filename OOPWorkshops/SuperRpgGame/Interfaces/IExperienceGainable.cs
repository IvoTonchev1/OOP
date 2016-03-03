using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRpgGame.Interfaces
{
    public interface IExperienceGainable
    {
        int Experience { get; }
        void LevelUp();
    }
}
