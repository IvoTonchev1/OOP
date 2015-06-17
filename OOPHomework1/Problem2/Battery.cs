using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Battery
    {
        private string battery;
        private double batLife;
        public Battery(string battery, double batLife)
        {
            this.Batter = battery;
            this.BatLife = batLife;
        }
        public string Batter
        {
            get
            {
                return this.battery;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No battery parameters entered.");
                }
                this.battery = value;
            }
        }
        public double BatLife 
        {
            get
            {
                return this.batLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be > 0.");
                }
                this.batLife = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Battery: {0} \nBattery Life: {1}", this.battery, this.batLife.ToString());
        }
    }
}
