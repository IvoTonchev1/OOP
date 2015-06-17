using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }
        public void DeleteCourse(string course)
        {
            Console.WriteLine(course + " has been deleted.");
        }
    }
}
