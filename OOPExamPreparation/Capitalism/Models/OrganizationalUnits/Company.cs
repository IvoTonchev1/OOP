using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitalism.Models.Interfaces;

namespace Capitalism.Models.OrganizationalUnits
{
    public class Company : IOrganizationalUnit
    {
        private IList<IOrganizationalUnit> subUnits;
        private IList<IEmployee> employees;

        public Company(string name)
        {
            this.subUnits = new List<IOrganizationalUnit>();
            this.employees = new List<IEmployee>();
            this.Name = name;
        }
        public string Name { get; private set; }

        public IEnumerable<IOrganizationalUnit> SubUnits
        {
            get { return this.subUnits; }
        }

        public IEnumerable<IEmployee> Employees
        {
            get { return this.employees; }
        }

        public IEmployee Head { get; private set; }
        public void AddSubUnit(IOrganizationalUnit unit)
        {
            this.subUnits.Add(unit);
        }

        public void AddEmployee(IEmployee employee)
        {
            this.employees.Add(employee);
        }
    }
}
