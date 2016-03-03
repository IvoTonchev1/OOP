using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08.EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter range start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter range end:");
            int end = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            Console.WriteLine(string.Join("<", ReadNumber(start, end)));           

        }

        public static List<int> ReadNumber(int start, int end)
        {
            int count = 0;
            List<int> result = new List<int>();
            int number;
            int temp = 0;
            while (count < 10)
            {
                try
                {
                    Console.WriteLine("Enter number:");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new ArgumentNullException("input", "Input cannot be empty.");
                    }
                    if (!int.TryParse(input, out number))
                    {
                        throw new ArithmeticException("input");
                    }
                    if (number < start || number > end)
                    {
                        throw new ArgumentOutOfRangeException("input", string.Format("Number should be in range {0}...{1}", start, end));
                    }
                    if (number < temp)
                    {
                        throw new ArgumentException("input", "Number should be bigger than the previously entered number.");
                    }
                    count++;
                    temp = number;
                    result.Add(number);

                }
                catch (ArgumentNullException ax)
                {
                    Console.Error.WriteLine(ax.Message);
                }
                catch (ArithmeticException ax)
                {
                    Console.Error.WriteLine("Invalid Number.");
                }
                catch (ArgumentOutOfRangeException aox)
                {
                    Console.Error.WriteLine(aox.Message);
                }
                catch (ArgumentException ax)
                {
                    Console.Error.WriteLine(ax.Message);
                }
            }
            return result;
        }
    }
}
