using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_CashFlowManager
{
    class HourlyEmployee : Employee
    {
        private decimal totalwage;
        private decimal totaltime;
        private decimal overtime;
        private decimal hourlywage;
        public HourlyEmployee(string First, string Last, string SSN, decimal HourlyWage, int HoursWorked) : base(First, Last, SSN, LedgerType.Hourly)
        {
            totaltime = HoursWorked;
            hourlywage = HourlyWage;
            if (totaltime > 40)
            {
                overtime = totaltime - 40;
                totalwage = hourlywage * 40;
                totalwage = totalwage + (overtime * (1.5m * hourlywage));
            }
            else
            {
                totalwage = hourlywage * HoursWorked;
            }
        }
        public override decimal Earnings()
        {
            return totalwage;
        }
        public override string ToString()
        {
            return string.Format("\n" + "Hourly employee: " + firstName + " " + lastName + "\n" + "SSN: " + SSN + "\n" + "Hourly wage Salary: {0:C}\n" + "Hours Worked: {1:0.00}\n" + "Earned: {2:C}" + "\n", hourlywage, totaltime, totalwage);
        }
    }
}
