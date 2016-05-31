using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_for_status_of_event
{
    public class Event
    {
        DataHelper dh = new DataHelper();
        public int GetNrOfPplWhoWillVisitEvent()
        {
            String sql = "SELECT COUNT(*) FROM visitor;";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            int nrofpeople=0;
            try
            {
                dh.connection.Open();
                nrofpeople = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("Error while loading nr of visitors.");
            }
            finally
            {
                dh.connection.Close();
            }
            return nrofpeople;
        }
        public int GetNrOfPplAtEvent()
        {

            String sql = "select count(*) from `visitor` where `Active`=1;";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            int atevent = 0;
            try
            {
                dh.connection.Open();
                atevent = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("Error while loading nr of visitors at event.");
            }
            finally
            {
                dh.connection.Close();
            }
            return atevent;
        }

        public int GetNrOfPplWhoLeft()
        {
            String sql = "select count(*) from `visitor` where `Active`=0;";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            int notatevent = 0;
            try
            {
                dh.connection.Open();
                notatevent = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("Error while loading nr of visitors who left.");
            }
            finally
            {
                dh.connection.Close();
            }
            return notatevent;
        }
    }
}
