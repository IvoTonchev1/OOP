using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;
        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }
        public int NumberOfVisits 
        {
            get
            {
                return this.numberOfVisits;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Number of visits must be non-negative number.");
                }
                this.numberOfVisits = value;
            }
        }
        public override string ToString()
        {
            string result = base.ToString();
            result += "Number of visits: " + this.NumberOfVisits + "\r\n";

            return result;
        }
    }
}
