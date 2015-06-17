using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastname, int age, int studentNumber, double averageGrade)
            : base(firstName, lastname, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }
        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Student number must be positive number.");
                }
                this.studentNumber = value;
            }
        }
        public double AverageGrade 
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "AverageGrade must be positive number.");
                }
                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "Student number: " + this.StudentNumber + "\r\n";
            result += String.Format("Average grade: {0:f2}\r\n", this.AverageGrade);

            return result;
        }
    }
}
