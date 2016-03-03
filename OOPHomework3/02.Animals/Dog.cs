using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public class Dog : Animal
    {
        private string breed;
        public Dog(string name, int age, string gender, string breed) : base(name, age, gender)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Breed cannot be null, whitespace or empty.");
                }
                this.breed = value;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau Bau!");
        }
    }
}
