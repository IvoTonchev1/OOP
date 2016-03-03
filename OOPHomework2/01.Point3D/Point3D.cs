using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;
        static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Point3D StartingPointReturn()
        {
            return StartingPoint;
        }
        public override string ToString()
        {
            string point = "x = " + this.X + "\ny = " + this.Y + "\nz = " + this.Z;
            return point;
        }


    }
}
