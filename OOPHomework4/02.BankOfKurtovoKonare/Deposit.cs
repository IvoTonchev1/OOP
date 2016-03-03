using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate, int duration) : base(customer, balance, interestRate, duration)
        {
            if (balance <= 1000)
            {
                this.InterestRate = 0;
            }
        }
        public void Withdraw(decimal value)
        {
            if (value <= this.Balance)
            {
                this.Balance -= value;
            }
            else
            {
                throw new ArgumentException("Not enough money in the balance");
            }
        }
    }
}
