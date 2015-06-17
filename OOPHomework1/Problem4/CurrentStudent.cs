using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class CurrentStudent : Student
    {
        private string currentCourse;
        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }
        public string CurrentCourse 
        {
            get
            {
                return this.currentCourse;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Current course must exist.");
                }
                this.currentCourse = value;
            }
        }
        public override string ToString()
        {
            string output = base.ToString();
            output += "Current course: " + this.currentCourse + "\n";
            return output;
        }
    }
}
