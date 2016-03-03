using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private int duration;
        protected Account(Customer customer, decimal balance, decimal interestRate, int duration)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Duration = duration;
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value >= 0)
                {
                    this.balance = value;
                }
                else
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value >= 0 && value <= 2)
                {
                    this.interestRate = value;
                }
                else
                {
                    throw new ArgumentException("Interest rate must be between 0 and 2");
                }
            }
        }
        public Customer Customer { get; set; }
        public int Duration { get; set; }

        public virtual decimal CalculateInterest()
        {
            return this.Balance * (1 + this.InterestRate * this.Duration);            
        }

        public virtual void Deposit(decimal value)
        {
            this.Balance += value;
        }
    }
}
