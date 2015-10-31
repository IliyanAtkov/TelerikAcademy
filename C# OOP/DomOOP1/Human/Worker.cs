namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Worker : Human
    {
        private const int WorkDaysPerWeek = 5;
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary

        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary canoot be less than zero");
                }
                this.weekSalary = value;

            }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours canoot be less than zero");
                }
                this.workHoursPerDay = value;
            }
        }

        public  decimal MoneyPerHour()
        {
            decimal moneyPerHour;
            decimal workHoursPerWeek = workHoursPerDay * WorkDaysPerWeek;
            return moneyPerHour = weekSalary / workHoursPerWeek;
        }
    }
}
