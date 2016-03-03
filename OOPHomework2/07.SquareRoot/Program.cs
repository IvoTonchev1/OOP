using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException("input", "Input cannot be empty");
                }
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("number", "Sqrt for negative numbers is undefined!");
                }
            
                PrintSquareRoot(CalculateSquareRoot(number));
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        private static void PrintSquareRoot(double number)
        {
            Console.WriteLine(number);
        }

        private static double CalculateSquareRoot(int number)
        {
            double result = Math.Sqrt(number);
            return result;
        }
        
    }
}
