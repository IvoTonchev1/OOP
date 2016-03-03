using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (Regex.IsMatch(value, "[a-zA-Z0-9]{5,10}"))
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number");
                }
            }
        }
    }
}
