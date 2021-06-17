using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_CashFlowManager
{
    class SalariedEmployee : Employee
    {
       private decimal weeklysalary;
       public SalariedEmployee(string First, string Last, string SSN, decimal WeeklySalary) : base(First,Last,SSN,LedgerType.Salaried)
        {
            weeklysalary = WeeklySalary;
        }
        public override decimal Earnings()
        {
            return weeklysalary;
        }
        public override string ToString()
        {
            return string.Format("\n" + "Salaried employee: " + firstName + " " + lastName + "\n"    + "SSN: " + SSN + "\n"  + "Weekly Salary: {0:C}\n"  + "Earned: {1:C}\n"  + " ", weeklysalary, weeklysalary);
        }
    }
}
