using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppExitEvent
{
    public class DataHelper
    {
        public MySqlConnection connection;
        private int visitorid;
        List<int> rentids;
        public DataHelper()
        {
            //Establishing the connection
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339805;" +
                                    "user id=dbi339805;" +
                                    "password=1LD6XTYh06;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            rentids = new List<int>();
        }

        //searches if there is a user with the specified rfid in the database 
        public bool CheckUser(string rfid)
        {
            String sql = "SELECT * FROM visitor";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (rfid == Convert.ToString(reader[8]))
                    {
                        visitorid =Convert.ToInt32(reader[0]);
                        connection.Close();
                        if (AllowUser(visitorid, rfid))
                        {
                            return true; 
                        } 
                        else 
                            return false;
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

        //checks if a visitor has equipment to return, if yes-returns false and doesn't check him out
        //if yes - returns true and checks the user out 
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
                UnassignMethod(idIn, rfid);
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
        //sets the rfid to null and makes the user unactive
        private void UnassignMethod(int idin,string rfid)
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

        //returns the names of all rented by the user equipment;
        public List<string> GetAllRented()
        {
            List<string> rented = new List<string>();
            List<int> ids = new List<int>();

            String sql = "SELECT * FROM rent_equipment WHERE VISITOR_VisitorID =" + visitorid;
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DBNull.Value.Equals(reader[4]))
                    {
                        ids.Add(Convert.ToInt32(reader[2]));
                        rentids.Add(Convert.ToInt32(reader[0]));
                    }

                }
                reader.Close();

                rented = PrivateGetListEquipment(ids);
                return rented;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return rented;


        }

        //returns the RentID's of all rented equipment
        private List<string> PrivateGetListEquipment(List<int> ids)
        {
            List<string> rented = new List<string>();

            foreach (int i in ids)
            {
                String sql1 = "SELECT * FROM equipment WHERE EquipmentID = " + i + ";";
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    string itemname = reader1[1].ToString();
                    rented.Add(itemname);
                }
                reader1.Close();

            }
            return rented;

        }

        //sets the EndDate and returns all rented by the user equipment
        public bool ReturnAll()
        {

            bool x = true;
            try
            {
                connection.Open();

                    DateTime date = DateTime.Now;

                    //foreach item in list update
                    foreach (var e in rentids)
                    {
                        String sql = "UPDATE rent_equipment SET EndDate = " + "'" + date.ToString("yyyy-MM-dd HH:mm:ss") + "'" + " WHERE RentID = " + e + ";";
                        MySqlCommand command = new MySqlCommand(sql, connection);

                        command.ExecuteNonQuery();
                    }

                x = true;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
                x = false;
            }
            finally
            {
                connection.Close();
            }
            return x;
        }
    }
}
