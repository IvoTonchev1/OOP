using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        IOrganizationalUnit InUnit { get; }
        decimal SalaryFactor { get; }
    }
}
