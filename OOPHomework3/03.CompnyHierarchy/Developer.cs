using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;
        public Developer(int id, string firstName, string lastName, decimal salary, Department department, List<Project> projects) : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }
        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("\nRole: Developer\n");
            result += string.Format("Projects: ");

            List<string> projectNames = new List<string>();
            foreach (var proj in this.Projects)
            {
                projectNames.Add(proj.Name);
            }

            result += string.Join(", ", projectNames) + "\n";

            return result;
        }
    }
}
