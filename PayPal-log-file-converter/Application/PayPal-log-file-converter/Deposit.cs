using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPal_log_file_converter
{
    public class Deposit
    {
        public int IdNr { get; set; } // respectively TransactionID in `transactions`
        public double Amount { get; set; } // // respectively AmountDeposited in `transactions`
        public int VisitorID { get; set; }

        public Deposit(int id, double amount, int visitorid)
        {
            this.IdNr = id;
            this.Amount = amount;
            this.VisitorID = visitorid;
        }
        public override string ToString()
        {
            return IdNr + " " + Amount;
        }
    }
}
