using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ChipSetApp
{
    public class DataHelper
    {
        public MySqlConnection connection;
        private int id;
        public int IdExported { get { return id; } }

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
        public bool CheckUser(int idIn, string Fname, string Lname, string Email)
        {
            String sql = "SELECT * FROM visitor";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (idIn == Convert.ToInt32(reader[0]) && Fname == Convert.ToString(reader[1]) && Lname ==
                        Convert.ToString(reader[2]) && Email == Convert.ToString(reader[5]))
                    {
                        this.id = Convert.ToInt32(reader[0]);
                        return true;
                    }

                }
                return false;
            }
            catch
            {
                MessageBox.Show("Error while loading from the database..");
            }
            finally
            {
                connection.Close();
            }
            return false;
        }



        //A method whitch Assignes the RFID to the user which has the input ID
        private void AssignRFID(string rfid, int idin)
        {
            string query = "UPDATE `dbi339805`.`visitor` SET `RFID` = '" + rfid + "', `Active` = 1 WHERE `VisitorID` = '" + idin + "';";
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

        //Public method which decides if the user has the permission to call the assignMethod()
        public void RFIDgiver(int idin, string Fname, string Lname, string Email, string RFID)
        {
    
            String sql = "SELECT * FROM visitor";
            MySqlCommand allUsers = new MySqlCommand(sql, connection);
          
            try
	        {	        
		     connection.Open();
             MySqlDataReader search = allUsers.ExecuteReader();
                
                String name;
                //int id;
                string email ;
                string Lastname;
                string rfid;
                
                while (search.Read())
                {
                    
                    name=Convert.ToString(search[1]);
                    Lastname  = Convert.ToString(search[2]);
                    email =Convert.ToString(search[5]);
                    rfid = Convert.ToString(search[8]);
                    if(DBNull.Value.Equals(search[8]))
                    {
                        //Series of checks to find if the user exists
                        if (Fname==name && Lname==Lastname && email==Email && id==idin)
                        {
                           search.Close();
                           connection.Close();
                           AssignRFID(RFID, idin);
                           break;
                         
                        }
                    } 
                }
	        }
	
            catch(Exception exc)
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


