using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (Person.IsValidName(value))
                {
                    this.productName = value;
                }
            }
        }

        public DateTime Date { get; set; }


        public decimal Price
        {
            get  { return this.price; }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Price must be positive!");
                }
            }
        }
    }
}
