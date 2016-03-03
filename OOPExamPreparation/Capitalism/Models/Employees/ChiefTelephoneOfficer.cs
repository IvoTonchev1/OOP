using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitalism.Models.Interfaces;

namespace Capitalism.Models.Employees
{
    public class ChiefTelephoneOfficer : Employee
    {
        private const decimal SalaryFactorDefault = -0.02m;
        public ChiefTelephoneOfficer(string firstName, string lastName, IOrganizationalUnit inUnit) : base(firstName, lastName, inUnit, SalaryFactorDefault)
        {
        }

    }
}
