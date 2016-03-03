using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRpgGame.Interfaces
{
    public interface IRenderer
    {
        void WriteLine(string message, params object[] parameters);
        void Clear();

    }
}
