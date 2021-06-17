using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_CashFlowManager
{
    interface IPayable 
    {
        public decimal GetPayableAmount();
        public LedgerType Ledger_ { get; }


    }

}
