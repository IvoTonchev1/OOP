using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Empires.Core;
using Empires.Core.Factories;
using Empires.IO;

namespace Empires
{
    public class EmpiresApplication
    {
        static void Main()
        {
            var buildingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new EmpiresData();

            var engine = new Engine(buildingFactory, resourceFactory, unitFactory, data, reader, writer);
            engine.Run();
        }
    }
}
