using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClassDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");

            unnamed.Breed = "German Shepard";

            unnamed.Bark();
            sharo.Bark();
        }
    }
}
