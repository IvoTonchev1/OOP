using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = firstPoint.X - secondPoint.X;
            double deltaY = firstPoint.Y - secondPoint.Y;
            double deltaZ = firstPoint.Z - secondPoint.Z;

            double distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);

            return distance;
        }
    }
}
