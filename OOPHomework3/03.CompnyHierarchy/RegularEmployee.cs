using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public abstract class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, Department department) : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
