using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_CashFlowManager
{
    class InVoice : IPayable
    {
        private string partNumber;
        private string partDescription;
        private int quantity;
        private decimal price;
        public InVoice(string PartNumber, string PartDescription, int Quanitity, decimal Price)
        {
            partNumber = PartNumber;
            partDescription = PartDescription;
            quantity = Quanitity;
            price = Price;
        }
        public string partnum
        {
            get { return partNumber; }
        }
        public string partdes
        {
            get { return partDescription; }
        }
        public int quant
        {
            get { return quantity; }
        }
        public decimal Pwice
        {
            get { return price; }
        }
        public decimal GetPayableAmount()
        {
            return quantity * price;
        }
        public LedgerType Ledger_ { get { return LedgerType.Invoice; } }
        public override string ToString()
        {
            return string.Format("\n" + "Invoice: " + partNumber + "\n" + "Quantity: " + quant + "\n" + "Part Description: " + partDescription + "\n"  + "Unit Price: {0:C}\n" + "Extended Price: {1:C}"  + "\n", price, GetPayableAmount());


        }
    }
}
