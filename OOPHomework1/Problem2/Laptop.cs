using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Laptop
    {
        private string model;
        private string manuf;
        private int ram;
        private string proc;
        private string graph;
        private string hdd;
        private string screen;
        private double price;
        private Battery battery;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, double price, string manuf, int ram)
            : this(model, price)
        {
            this.Manuf = manuf;
            this.Ram = ram;
        }
        public Laptop(string model, double price, string manuf, int ram, string proc, string graph, string hdd)
            : this(model, price, manuf, ram)
        {
            this.Proc = proc;
            this.Graph = graph;
            this.Hdd = hdd;
        }
        public Laptop(string model, double price, string manuf, int ram, string proc, string graph, string hdd, string screen, Battery battery)
            : this(model, price, manuf, ram, proc, graph, hdd)
        {
            this.Screen = screen;
            this.battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Laptop model is mandatory.");
                }
                this.model = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Laptop should have non-negative price.");
                }
                this.price = value;
            }
        }
        public int Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Laptop should have positive RAM.");
                }
                this.ram = value;
            }
        }
        public string Manuf 
        {
            get { return this.manuf; }
            set { this.manuf = value; }
        }
        public string Proc
        {
            get { return this.proc; }
            set { this.proc = value; }
        }
        public string Graph
        {
            get { return this.graph; }
            set { this.graph = value; }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }
        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }
        public void Battery(Battery battery)
        {
            this.battery = battery;
        }
        public override string ToString()
        {
            string output = "Model: " + this.model + "\n";
            if (!String.IsNullOrEmpty(this.manuf))
                output += "Manufacturer: " + this.manuf + "\n";
            if (!String.IsNullOrEmpty(this.proc))
                output += "Processor: " + this.proc + "\n";
            if (this.Ram != 0)
                output += "RAM: " + this.ram + " GB" + "\n";
            if (!String.IsNullOrEmpty(this.graph))
                output += "Graphics card: " + this.graph + "\n";
            if (!String.IsNullOrEmpty(this.hdd))
                output += "HDD: " + this.hdd + "\n";
            if (!String.IsNullOrEmpty(this.screen))
                output += "Screen: " + this.screen + "\n";
            output += battery + "\n";
            output += "Price: " + this.price + " lv.\n";
            return output;
        }
    }
}
