using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }

        public List<Point3D> Path { get; set; }

        public void AddPoint(Point3D point)
        {
            var currentPath = this.Path;
            currentPath.Add(point);
            this.Path = currentPath;
        }

        public override string ToString()
        {
            return this.Path.Aggregate("\r\n", (current, point) => current + ("\t" + point.ToString() + "\r\n"));
        }
    }
}
