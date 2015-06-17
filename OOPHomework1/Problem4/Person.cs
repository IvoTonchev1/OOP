using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Person
    {
        private string firstName;
        private int age;
        private string lastName;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name must exist.");
                }
                this.firstName = value;
            }
        }
        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Age must be positive number.");
                }
                this.age = value;
            }
        }
        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name must exist.");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("{1}, {0}\r\n", this.FirstName, this.LastName);
            result += "Age: " + this.Age + "\r\n";

            return result;
        }
    }
}
