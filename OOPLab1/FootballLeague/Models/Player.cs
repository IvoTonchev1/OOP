using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;
        private const int MinimumAllowedYear = 1980;

        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name must be at least 3 characters long.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Last name must be at least 3 characters long.");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Birth year cannot be earlier than " + MinimumAllowedYear);
                }
                this.dateOfBirth = value;
            }
        }

        public Team Team { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} (born: {2}, salary: {3}", this.FirstName, this.LastName, this.DateOfBirth,
                this.Salary);
        }
    }
}
