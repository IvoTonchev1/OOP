using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AnimalFarm
{
    class Chicken : Animal
    {
        public Chicken(string name, int age)
            : base(name, age)
        {
        }

        public override Product ProduceProduct()
        {
            return new Product();
        }

        public override double GetHumanAge()
        {
            return this.Age * 11;
        }
    }
}
