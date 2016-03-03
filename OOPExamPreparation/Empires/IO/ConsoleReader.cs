using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires.IO
{
    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
