using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CustomListT
{
    public class TestT
    {
        static void Main(string[] args)
        {
            var list = new CustomList<int>(2);
            list.Add(0);
            list.Add(5);
            list.Add(-1);
            Console.WriteLine(list.IndexOf(5));
            Console.WriteLine(list.IndexOf(11));
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            list.Remove(5);
            Console.WriteLine(list[1]);
        }
    }
}
