using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Engine;
using SuperRpgGame.Interfaces;
using SuperRpgGame.UI;

namespace SuperRpgGame
{
    public class SuperRpgGameApp
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            IInputReader reader = new ConsoleInputReader();
            SuperEngine engine = new SuperEngine(reader, renderer);
            engine.Run();

        }
    }
}
