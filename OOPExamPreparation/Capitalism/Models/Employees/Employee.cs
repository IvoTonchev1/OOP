using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitalism.Models.Interfaces;

namespace Capitalism.Models.Employees
{
    public abstract class Employee : IEmployee
    {
        public Employee(string firstName, string lastName, IOrganizationalUnit inUnit, decimal salaryFactor)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.InUnit = inUnit;
            this.SalaryFactor = salaryFactor;
        }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public IOrganizationalUnit InUnit { get; protected set; }
        public decimal SalaryFactor { get; protected set; }
    }
}
