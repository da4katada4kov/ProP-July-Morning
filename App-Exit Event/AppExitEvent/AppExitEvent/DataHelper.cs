using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppExitEvent
{
    class DataHelper
    {
        public MySqlConnection connection;
        

        public DataHelper()
        {
            //Establishing the connection
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339805;" +
                                    "user id=dbi339805;" +
                                    "password=1LD6XTYh06;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }


        //Method that searches if there is such a user in the database Returns true or false
        public bool CheckUser(int idIn, string rfid)
        {
            String sql = "SELECT * FROM visitor";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (idIn == Convert.ToInt32(reader[0]) && rfid == Convert.ToString(reader[8]))
                    {
                        connection.Close();
                        if (AllowUser(idIn, rfid))
                        {
                            return true; 
                        } 
                        else return false;
                    }

                }
                return false;
            }
            catch
            {
                MessageBox.Show("error while loading from the database..");
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        private bool AllowUser(int idIn, string rfid)
        {
            String sql = "SELECT DISTINCT v.VisitorID FROM `rent_equipment` e join `visitor` v on(e.VISITOR_VisitorID=v.VisitorID) WHERE EXISTS (SELECT * FROM `rent_equipment` t Where t.VISITOR_VisitorID=e.VISITOR_VisitorID AND t.EndDate is null) AND e.VISITOR_VisitorID=" +idIn;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (idIn == Convert.ToInt32(reader[0]))
                    {
                        connection.Close();
                       
                        return false;
                    }

                }
                connection.Close();
                assignMethod(idIn, rfid);
                return true;
            }
            catch
            {
                MessageBox.Show("error while loading from the database..");
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        private void assignMethod( int idin,string rfid)
        {
            string query = "UPDATE `dbi339805`.`visitor` SET `RFID` = '" + null + "', `Active` = 0 WHERE `VisitorID` = '" + idin + "';";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

            finally
            {
                connection.Close();
            }
        }

 
    

    }
}
