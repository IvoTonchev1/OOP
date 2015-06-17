using System;

class Component : IComparable
{
    private string name;
    private decimal price;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("name", "Name cannot be empty.");
            }

            this.name = value;
        }
    }

    public string Details { get; set; }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("price", "Price cannot be negative.");
            }

            this.price = value;
        }
    }

    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public Component(string name, decimal price, string details)
        : this(name, price)
    {
        this.Details = details;
    }

    public int CompareTo(object obj)
    {
        Component component = (Component)obj;
        return this.Price.CompareTo(component.Price);
    }
}


