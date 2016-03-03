using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompnyHierarchy
{
    public class CompanyHierarchyMain
    {
        static void Main(string[] args)
        {
            var employees = new List<Person>()
            {
                new Manager(123, "Some", "Guy", 1243, Department.Marketing, new List<Employee>()
                {
                    new SalesEmployee(124, "Other", "Guy", 200, Department.Sales, new List<Sale>()
                    {
                        new Sale("Something", new DateTime(), 23.8M )
                    }),
                    new Developer(125, "And", "Guy", 500, Department.Marketing, new List<Project>()
                    {
                        new Project("Alabala", new DateTime(), "Sub project", State.Open)
                    }),
                }),
                new SalesEmployee(126, "Ga", "mani", 600, Department.Sales, new List<Sale>()
                {
                    new Sale("Some", new DateTime(), 123.4M )
                }),
                new Customer(345, "Sas", "asds", 1234.5M),
                new Developer(135, "Dev", "Guy", 2500, Department.Production, new List<Project>()
                {
                    new Project("Proj", new DateTime(), "Test project", State.Open)
                }),
                new SalesEmployee(150, "Emply", "asdas", 19238, Department.Production, new List<Sale>()
                {
                    new Sale("Something new", new DateTime(), 283.8M )
                })
            };

            employees.ForEach(Console.WriteLine);
        }
    }
}
