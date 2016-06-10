using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPal_log_file_converter
{
    class LogFile
    {
        public int OrganizationBankAccount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NrOfDeposits { get; set; }
        public List<Deposit> deposits { get; set; }

        public LogFile()
        {
            deposits = new List<Deposit>();
        }

        public void AddDeposit(Deposit d)
        {
            deposits.Add(d);
        }
        public void ClearList()
        {
            deposits.Clear();
        }
    }
}
