using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            Laptop Lenovo = new Laptop("Lenovo Yoga 2 Pro", 2259.00, "Lenovo", 8, "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "Intel HD Graphics 4400", "128GB SSD",
                "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5));
            Laptop Dell = new Laptop("Dell Inspiron", 3400, "Dell", 16);
            Laptop HP = new Laptop("HP Compaq", 956, "HP", 2, "AMD 4-1.7GHz", "Nvidia GeForce 5000", "256GB SSD");
            Laptop IBM = new Laptop("IBM", 1567);
            Battery temp = new Battery("Li-Mag", 6);
            IBM.Battery(temp);

            Console.WriteLine(Lenovo);
            Console.WriteLine();
            Console.WriteLine(Dell);
            Console.WriteLine();
            Console.WriteLine(HP);
            Console.WriteLine();
            Console.WriteLine(IBM);
        }
    }
}
