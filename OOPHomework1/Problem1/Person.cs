using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Person
    {
        private string name;
        private int age;
        private string email;
        public Person(string name, int age) : this(name, age, null)
        {          
        }
        public Person (string name, int age, string email)
	    {
            this.Name = name;
            this.Age = age;
            this.Email = email;
	    }
        public string Name {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name should contain non-empty characters.");
                }
                this.name = value;
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
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("The age must be between 1 and 100.");
                }
                this.age = value;
            }
        }

        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.email = "(none)";
                }
                else if (!value.Contains("@"))
                {
                    throw new ArgumentException("The email must contain \"@\"");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0} \n Age: {1} \n Email: {2}", this.name, this.age, this.email);
        }
    }
}
