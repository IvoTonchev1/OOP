using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, List<Sale> sales) : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }
        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("\nRole: Sales Employee\n");
            result += string.Format("Sales made: {0}\n", this.Sales.Count);
            return result;
        }
    }
}
