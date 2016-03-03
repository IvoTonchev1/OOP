using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CohesionAndCoupling.Engine;
using _08.CohesionAndCoupling.Interfaces;
using _08.CohesionAndCoupling.UI;

namespace _08.CohesionAndCoupling
{
    public class BookStoreMain
    {
        static void Main(string[] args)
        {
            IInputHandler inputHandler = new ConsoleInputHandler();
            IRenderer renderer = new ConsoleRenderer();
            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);
            engine.Run();
        }
    }
}
