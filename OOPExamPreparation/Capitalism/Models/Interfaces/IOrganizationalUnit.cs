using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitalism.Models.Employees;

namespace Capitalism.Models.Interfaces
{
    public interface IOrganizationalUnit
    {
        string Name { get; }
        IEnumerable<IOrganizationalUnit> SubUnits { get; }
        IEnumerable<IEmployee> Employees { get; } 
        IEmployee Head { get; }
        void AddSubUnit(IOrganizationalUnit unit);
        void AddEmployee(IEmployee employee);

    }
}
