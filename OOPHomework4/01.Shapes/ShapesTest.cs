using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            var shapes = new List<BasicShape>()
            {
                new Rectangle(15, 12.4),
                new Rhombus(6, 5),
                new Circle(3)
            };

            shapes.ForEach(x =>
            {
                Console.WriteLine("{0}, P = {1:f}, Area = {2:f}",
                    x.GetType().Name, x.CalculatePerimeter(), x.CalculateArea());
            });
        }
    }
}
