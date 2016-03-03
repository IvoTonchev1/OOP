using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees;
        public Manager(int id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees) : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }
        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("\nRole: Manager\n");
            result += string.Format("Employees managed: ");

            List<string> employeeNames = new List<string>();
            foreach (Employee employee in this.Employees)
            {
                employeeNames.Add(string.Format("{0} {1}", employee.FirstName, employee.LastName));
            }

            result += string.Join(", ", employeeNames) + "\n";

            return result;
        }
    }
}
