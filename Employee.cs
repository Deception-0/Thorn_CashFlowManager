using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_CashFlowManager
{
    public abstract class Employee : IPayable
    {
        private string FirstName;
        private string LastName;
        private string SSN_;
        private LedgerType LedgeLuthor;
        public Employee(string First, string Last, string SSN, LedgerType ledge)
        {
            FirstName = First;
            LastName = Last;
            SSN_ = SSN;
            LedgeLuthor = ledge;
        }
        public string firstName
        {
            get { return FirstName; }
        }
        public string lastName
        {
            get { return LastName; }
        }
        public string SSN
        {
            get { return SSN_; }
        }
        public abstract decimal Earnings();
        public LedgerType Ledger_ { get { return LedgeLuthor; } }
        public decimal GetPayableAmount()
        {
            return Earnings();
        }
       
    }
}
