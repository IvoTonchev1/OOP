using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;
        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }
        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Dropout Reason must exist.");
                }
                this.dropoutReason = value;
            }
        }
        public void Reapply()
        {
            Console.WriteLine("First Name: " + this.FirstName + "\nLast Name: " + this.LastName + "\nAge: " + this.Age + "\nStudent Number: "
                + this.StudentNumber + "\nAverage Grade: " + this.AverageGrade + "\nDropout Reason: " + this.DropoutReason);
        }
        public override string ToString()
        {
            string result = base.ToString();
            result += "Dropout reason: " + this.DropoutReason + "\r\n";

            return result;
        }
    }
}
