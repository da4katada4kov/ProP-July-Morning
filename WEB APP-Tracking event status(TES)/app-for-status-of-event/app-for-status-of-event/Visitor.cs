using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_for_status_of_event
{
    public class Visitor
    {
        DataHelper dh = new DataHelper();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public int Active { get; set; }
        public double Balance { get; set; }
        public Visitor GetVisitorStatus(int visitorid)
        {
            String sql = "SELECT * FROM visitor WHERE VisitorID = '" + visitorid + "';";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            Visitor v = new Visitor();
            try
            {
                dh.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    v.FirstName = reader[1].ToString();
                    v.LastName = reader[2].ToString();
                    v.Active = Convert.ToInt32(reader[6]);
                }
                if (v.FirstName == null)
                    v = null;
            }
            catch(MySqlException)
            {
                MessageBox.Show("Error while loading visitor.");
            }
            finally
            {
                dh.connection.Close();
            }
            return v;
        }
    }
}
