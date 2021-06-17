using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_CashFlowManager
{
    class Info
    {
        private int i = 0;
        IPayable[] Payables = new IPayable[50];
        public void Add(IPayable payable)
        {
           
            Payables[i] = payable;
            i++;

        }
        public string HowMuch()
        {
            decimal Total_Cost = 0;
            for (int C = 0; C < Payables.Length ; C++)
            {
                if (Payables[C] != null)
                {
                    Total_Cost = Payables[C].GetPayableAmount() + Total_Cost;
                }
            }
            return "Total Weekly Payout: " + string.Format("{0:C}", Total_Cost);
        }
        public string InvoiceHowMuch()
        {
            decimal Total_Cost = 0;
            for (int C = 0; C < Payables.Length; C++)
            {
                if (Payables[C] != null)
                {
                    if (Payables[C].Ledger_ == LedgerType.Invoice)
                    {
                   
                        Total_Cost = Payables[C].GetPayableAmount() + Total_Cost;
                    }
                }
            }
            return "Invoices: " + string.Format("{0:C}", Total_Cost);

        }
        public string SalaryHowMuch()
        {
            decimal Total_Cost = 0;
            for (int C = 0; C < Payables.Length; C++)
            {
                if (Payables[C] != null)
                {
                    if (Payables[C].Ledger_ == LedgerType.Salaried )
                    {
                   
                        Total_Cost = Payables[C].GetPayableAmount() + Total_Cost;
                    }
                }
            }
            return "Salaried Payroll: " + string.Format("{0:C}", Total_Cost);
        }
        public string HourlyHowMuch()
        {
            decimal Total_Cost = 0;
            for (int C = 0; C < Payables.Length; C++)
            {
                if (Payables[C] != null)
                {
                    if (Payables[C].Ledger_ == LedgerType.Hourly)
                    {
                   
                        Total_Cost = Payables[C].GetPayableAmount() + Total_Cost;
                    }
                }
            }
            return "Hourly Payroll: " + string.Format("{0:C}", Total_Cost);
        }
        public string InvoiceList()
        {
            string list = null;
            for (int C = 0; C < Payables.Length; C++)
            {
                if (Payables[C] != null)
                {
                    if (Payables[C].Ledger_ == LedgerType.Invoice)
                    {
                   
                        list += Payables[C].ToString();
                        
                    }
                }
            }
            return list;
        }
        public string HourlyList()
        {
            string list = null;
            for (int C = 0; C < Payables.Length; C++)
            {
                if (Payables[C] != null)
                {
                    if (Payables[C].Ledger_ == LedgerType.Hourly)
                    {
                  
                        list += Payables[C].ToString();

                    }
                }
            }
            return list;
        }
        public string SalariedList()
        {
            string list = null;
            for (int C = 0; C < Payables.Length; C++)
            {
                if (Payables[C] != null)
                {
                    if (Payables[C].Ledger_ == LedgerType.Salaried)
                    {
                 
                        list += Payables[C].ToString();

                    }
                }
            }
            return list;
        }
    }
}
