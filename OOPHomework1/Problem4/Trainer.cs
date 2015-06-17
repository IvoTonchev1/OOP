using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Created Course: " + courseName);
        }
    }
}
