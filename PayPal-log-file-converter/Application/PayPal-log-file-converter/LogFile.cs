using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPal_log_file_converter
{
    public class LogFile
    {
        public int OrganizationBankAccount { get; set; }//Some Properties
        public DateTime StartDate { get; set; }         //Some Properties
        public DateTime EndDate { get; set; }           //Some Properties
        public int NrOfDeposits { get; set; }           //Some Properties
        public List<Deposit> deposits { get; set; }     //Some Properties

       //Constructor
        public LogFile()
        {
            deposits = new List<Deposit>();
        }

        //method to add a deposit
        public void AddDeposit(Deposit d)
        {
            deposits.Add(d);
        }
        //Clears the deposits
        public void ClearList()
        {
            deposits.Clear();
        }
    }
}
