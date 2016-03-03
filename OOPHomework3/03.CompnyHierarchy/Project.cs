using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompnyHierarchy.Interfaces;

namespace _03.CompnyHierarchy
{
    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string name, DateTime date, string details, State state)
        {
            this.Name = name;
            this.StartDate = date;
            this.Details = details;
            this.State = state;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (Person.IsValidName(value))
                {
                    this.name = value;
                }
            }
        }

        public DateTime StartDate { get; set; }

        public string Details { get; set; }

        public State State { get; set; }

        public void CloseProject()
        {
            this.State = State.Closed;
        }
    }
}
