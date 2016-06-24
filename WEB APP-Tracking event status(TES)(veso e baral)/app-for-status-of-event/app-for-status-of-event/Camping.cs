using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_for_status_of_event
{
    public class Camping
    {
        DataHelper dh = new DataHelper();

        public int GetNrOfFreeSpots()
        {
            String sql = "SELECT COUNT(*) FROM booking";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            int occupied = 0;
            try
            {
                dh.connection.Open();
                occupied = Convert.ToInt32(command.ExecuteScalar()); 

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return 15 - occupied;
        }

    }
}
