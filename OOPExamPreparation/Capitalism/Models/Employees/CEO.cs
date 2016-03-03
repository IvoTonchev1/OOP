using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitalism.Models.Interfaces;

namespace Capitalism.Models.Employees
{
    public class CEO : Employee
    {
        private const decimal SalaryFactorDefault = 0;
        public CEO(string firstName, string lastName, IOrganizationalUnit inUnit, decimal salary)
            : base(firstName, lastName, inUnit, SalaryFactorDefault)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }
    }
}
