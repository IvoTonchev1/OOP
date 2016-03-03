using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public class AnimalsMain
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>()
            {
                new Cat("Catt", 10, "female"),
                new Cat("Grr", 14, "male"),
                new Cat("Caty", 1, "female"),
                new Dog("Dogy", 2, "female", "san bernar"),
                new Dog("Sharo", 5, "male", "pincher"),
                new Frog("FRogy", 4, "female"),
                new Frog("Pesho", 3, "male"),
                new Kitten("Catt", 3),
                new Tomcat("Catt", 6),
            };
            animals.ForEach(x =>
            {
                Console.WriteLine(x);
                x.ProduceSound();
            });

            var catalog = new Dictionary<string, List<double>>();
            animals.ForEach(x =>
            {
                string animalType = x.GetType().Name;
                if (!catalog.ContainsKey(animalType))
                {
                    catalog.Add(animalType, new List<double>());
                    catalog[animalType].Add(0);
                    catalog[animalType].Add(0);
                }

                catalog[animalType][0] += x.Age;
                catalog[animalType][1] += 1;
            });

            foreach (var animal in catalog)
            {
                Console.WriteLine("{0}s average age is {1:#.##} years", animal.Key, animal.Value[0] / animal.Value[1]);
            }
        }
    }
}
