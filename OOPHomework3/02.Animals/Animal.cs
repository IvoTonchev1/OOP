using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Animals.Interfaces;

namespace _02.Animals
{
    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null, whitespace or empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Age cannot be negative.");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("value", "Gender shoud be either male or female.");
                }
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return string.Format("My name is {0}, I'm {1} yrs old {2} {3}", this.Name, this.Age, this.Gender, GetType().Name);
        }

        public abstract void ProduceSound();
    }
}
