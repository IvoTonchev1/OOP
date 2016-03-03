using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person gosho = new Person("Gosho", "Goshev", 20);
            try
            {
                //Person tosho = new Person("", "Toshev", 21);
                //Person misho = new Person("Misho", null, 23);
                //Person pesho = new Person("Pesho", "Peshev", -12);
                //Person tisho = new Person("Tisho", "Tishev", 140);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            
            
        }
    }
}
