using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < -90 || 90 < value)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180 || 180 < value)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
