using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Week salary cannot be negative.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("value", "Work hours per day must be in range 0..24");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary/(7*this.WorkHoursPerDay);
        }
    }
}
