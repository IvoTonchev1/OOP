using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Id cannot be negative.");
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null, whitespace or empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null, whitespace or empty.");
                }
                this.lastName = value;
            }
        }
        public static bool IsValidName(string name)
        {
            if (Regex.IsMatch(name, "[a-zA-Z]{2,20}"))
            {
                return true;
            }

            throw new ArgumentException("Invalid name!");
        }

        public override string ToString()
        {
            string name = this.firstName + " " + this.lastName;

            return string.Format("My names is {0} and I'm {1}", name, GetType().Name);
        }
    }
}
