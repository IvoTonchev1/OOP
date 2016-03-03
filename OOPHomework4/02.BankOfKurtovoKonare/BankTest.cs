using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    public class BankTest
    {
        static void Main(string[] args)
        {
            Deposit deposit = new Deposit(new Individual("Gosho", 823), 489, 0.2m, 2);
            Console.WriteLine(deposit.InterestRate);
            deposit.Deposit(8190);
            Console.WriteLine(deposit.Balance);
            Loan newLoan = new Loan(new Company("IBM", 1), 10000, 0.3m, 20);
            Console.WriteLine(newLoan.CalculateInterest());
            Mortgage mortgage = new Mortgage(new Individual("Onufri", 12), 5000, 0.41m, 5);
            Console.WriteLine(mortgage.CalculateInterest());
            mortgage = new Mortgage(new Company("HP", 2), 20000, 0.5m, 8);
            Console.WriteLine(mortgage.CalculateInterest());
        }
    }
}
