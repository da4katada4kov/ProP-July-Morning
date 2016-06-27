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
        // selects nr of rented spots from db and calculates how many are free
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
        // selects all people who have entered the camping
        public int GetNrOfPeopleAtCamping()
        {
            String sql = "SELECT COUNT(*) FROM visitor WHERE Entered = 'true'";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            int nr=0;
            try
            {
                dh.connection.Open();
                nr = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return nr;
        }
        //selects nr of active spots
        public int GetNrOfActiveSpots()
        {
            String sql = "SELECT COUNT(*) FROM booking WHERE Entered ='true'";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            int nr = 0;
            try
            {
                dh.connection.Open();
                nr = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return nr;
        }
        //selects number of spots which are booked but no one has yet entered

        public int GetNrOfNonActiveSpots()
        {
            String sql = "SELECT COUNT(*) FROM booking WHERE Entered ='false'";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            int nr = 0;
            try
            {
                dh.connection.Open();
                nr = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return nr;
        }
    }
}
