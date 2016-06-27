using MySql.Data.MySqlClient;
using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Camping_Entrance
{
    public class Visitor
    {
        DataHelper dh = new DataHelper();
        public RFID myRFIDReader;
        public string TagSerial; //rfid nr

        public Visitor()
        {
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new TagEventHandler(SayHello);
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Error at start-up.");
            }
        }
        public void Open()
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException)
            {
                MessageBox.Show("No RFID-reader opened.");
            }
        }
        public void Close()
        {
            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();
        }
        public void SayHello(object sender, TagEventArgs e)
        {
            TagSerial = e.Tag;
        }
        /*
         * check GuestOf where RFID is equal to the inputed one
         * if the field is not null return true
         * check the spotid from booking using the mainId 
         * if the field is null return false
         */
        public bool CheckUser(string rfid, out int guestof)
        {
            bool x = false;
            guestof=0;
            String sql = "SELECT GuestOf FROM visitor WHERE RFID = "+ "'" + rfid + "'";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DBNull.Value.Equals(reader[0]))
                        x = false;
                    else
                    {
                        guestof = Convert.ToInt32(reader[0]);
                        x = true;
                    }
                }
            }
            catch (MySqlException exc)
            {
                MessageBox.Show("Error while loading from the database...");
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return x;
        }

        //gets the id of a spot by the id of the main visitor
        public int GetSpotID(int mainID)
        {
            int spotID = -1;
            String sql = "SELECT SpotID FROM booking WHERE ID_main = " + mainID;
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                spotID = (int)command.ExecuteScalar();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error while loading from the database...");
            }
            finally
            {
                dh.connection.Close();
            }
            return spotID;
        }

        //sets the visitor to enter in the camping
        private void assignMethod(int idin)
        {
            string query = "UPDATE `dbi339805`.`visitor` SET `Entered` = 'true' WHERE `VisitorID` = '" + idin + "';";
            MySqlCommand command = new MySqlCommand(query, dh.connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }
        // sets the camping spot as active
        public void SpotEnter(int spotid, int mainid)
        {
            string query = "UPDATE `dbi339805`.`booking` SET `Entered` = 'true' WHERE `SpotId` = '" + spotid + "';";
            MySqlCommand command = new MySqlCommand(query, dh.connection);
            try
            {
                dh.connection.Open();
                command.ExecuteNonQuery();
                assignMethod(mainid);

            }
            catch (MySqlException exc)
            {

                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
        }
        // sets the visitor to checed out of the camping
        public bool CheckOut(string rfid)
        {
            String sql = "UPDATE `dbi339805`.`visitor` SET `Entered` = 'false' WHERE `RFID` = '" + rfid + "';";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
            finally
            {
                dh.connection.Close();
            }
        }
    }
}
