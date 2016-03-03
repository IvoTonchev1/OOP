using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class Program
    {
        // In this project are the solutions of the first two problems from the static members homework
        static void Main(string[] args)
        {
            Point3D point = new Point3D(2, 3, 5);
            Point3D newPoint = new Point3D(30, -3, 13);
            Console.WriteLine("Coordinate Center:\n" + Point3D.StartingPointReturn());
            Console.WriteLine();
            Console.WriteLine("First point:\n" + point);
            Console.WriteLine();
            Console.WriteLine("Second point:\n" + newPoint);
            Console.WriteLine();
            Console.WriteLine("Distance between the points: " + DistanceCalculator.CalculateDistance(point, newPoint));
        }
    }
}
