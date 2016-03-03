using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchase;
        public Customer(int id, string firstName, string lastName, decimal netPurchase) : base(id, firstName, lastName)
        {
            this.NetPurchase = netPurchase;
        }
        public decimal NetPurchase
        {
            get
            {
                return this.netPurchase;
            }
            set
            {
                if (value >= 0)
                {
                    this.netPurchase = value;
                }
                else
                {
                    throw new ArgumentException("Net value of purchases cannot be negative!");
                }
            }
        }
        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("\nRole: Customer\n");
            result += string.Format("Net Spending Amount: {0:c2}\n", this.NetPurchase);
            return result;
        }
    }
}
