using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayPal_log_file_converter
{
    public class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()//Establishes the connection
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339805;" +
                                    "user id=dbi339805;" +
                                    "password=1LD6XTYh06;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
        // adds all transactions from the log file to the transactions table
        public bool AddLogToDatabase(int transactionid, double amount, DateTime enddate, int visitorid)
        {

            String sql = "INSERT INTO transactions(TransactionID, VISITOR_VisitorID, AmountDeposited, Date) VALUES (@transactionid, @visitorid, @amount, @enddate)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {

                
                command.Parameters.AddWithValue("@transactionid", transactionid);
                command.Parameters.AddWithValue("@visitorid", visitorid);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@enddate", enddate);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException )
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
