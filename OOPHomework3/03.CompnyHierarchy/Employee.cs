using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;
        protected Employee(int id, string firstName, string lastName, decimal salary, Department department) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Salary cannot be negative.");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }
    }
}
