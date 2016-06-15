using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace App_Camping_Entrance
{
    class DataHelper
    {
        public MySqlConnection connection;

        private  int IdMain;
        public  int MainId { get { return IdMain; } }
        private List<int> listOfId;

        private int hId;
        public int HouseId { get { return hId; } }
       
        public DataHelper()
        {
            //Establishing the connection
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339805;" +
                                    "user id=dbi339805;" +
                                    "password=1LD6XTYh06;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            listOfId = new List<int>();
        }

        private void Next()
        {
            hId = -1;
            listOfId = new List<int>();
            IdMain = -1;
        }

        //Method that searches if there is such a user in the database Returns true or false
        public bool CheckUser(int HouseidIn, int MainId)//& rfid
        {
            String sql = "SELECT * FROM booking";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (HouseidIn == Convert.ToInt32(reader[0]) && MainId == Convert.ToInt32(reader[1]))
                    {
                        this.hId = Convert.ToInt32(reader[0]);
                        IdMain = Convert.ToInt32(reader[1]);
                        connection.Close();

                        listOfId.Add(MainId);
                       // assignMethod(MainId);
                        return true;
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

        public bool CheckGuest( int Guestid)//& rfid
        {
            String sql = "SELECT * FROM booking where ID_main='"+MainId+"'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Guestid == Convert.ToInt32(reader[2]) ||
                        Guestid == Convert.ToInt32(reader[3]) ||
                        Guestid == Convert.ToInt32(reader[4]) ||
                        Guestid == Convert.ToInt32(reader[5]) ||
                        Guestid == Convert.ToInt32(reader[6]))
                    {

                        listOfId.Add(Guestid);
                       // assignMethod(Guestid);
                        return true;
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



        //A method whitch Assignes the RFID to the user which has the input ID
        private void assignMethod(/*string rfid*/ int idin)
        {
            string query = "UPDATE `dbi339805`.`visitor` SET `Entered` = 'true' WHERE `VisitorID` = '" + idin + "';";
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

        private void SpotEnter()
        {
            string query = "UPDATE `dbi339805`.`booking` SET `Entered` = 'true' WHERE `SpotId` = '" + HouseId + "';";
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

        //Public method which call the assignMethod() for the already verified users
        public void VerifyEntranceForAll()
        {
            foreach (var person in listOfId)
            {
                assignMethod(person);
            }
            SpotEnter();
            Next();
        }

    }
}
