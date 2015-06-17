using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            Person Penko = new Person("Penko", 25);
            Person Ginko = new Person("Ginko", 35, "Ginko@abv.bg");
            //Person Svetla = new Person("Svetla", 29, "Svetla.alabala.com");

            Console.WriteLine(Penko);
            Console.WriteLine();
            Console.WriteLine(Ginko);
            //Console.WriteLine(Svetla);
        }
    }
}
