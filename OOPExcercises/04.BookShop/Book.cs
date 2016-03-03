using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("title", "Title cannot be null or empty.");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("author", "Author cannot be null or empty");
                }
                this.author = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be negative.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0:f2}{1}", this.Price, Environment.NewLine);
            return output.ToString();
        }
    }
}
