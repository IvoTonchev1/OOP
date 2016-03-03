using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate, int duration) : base(customer, balance, interestRate, duration)
        {
        }
        public override decimal CalculateInterest()
        {
            decimal interest = this.Balance;
            if (Customer.GetType().Name == "Individual")
            {
                if (this.Duration - 3 > 0)
                {
                    interest = this.Balance * (1 + this.InterestRate * (this.Duration - 3));
                }
            }
            else
            {
                if (this.Duration - 2 > 0)
                {
                    interest = this.Balance * (1 + this.InterestRate * (this.Duration - 2));
                }
            }

            return interest;
        }
    }
}
