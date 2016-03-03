using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AnimalFarm
{
    class AnimalFarm
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Mara", 3);
            Console.WriteLine(chicken.ProductPerDay);
        }
    }
}
