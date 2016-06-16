using MySql.Data.MySqlClient;
using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public class VisitorReturn
    {
        DataHelper dh = new DataHelper();
        private RFID myRFIDReader;
        private string rfidtag;
        private List<int> rentids = new List<int>();

        public VisitorReturn()
        {
            try
            {
                myRFIDReader = new RFID();               
                myRFIDReader.Tag += new TagEventHandler(SayHello);
            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
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
                MessageBox.Show("no RFID-reader opened.");
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
            rfidtag = e.Tag;
            MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +"");

        }
        public List<Equipment> GetAllRented()
        {
            List<Equipment> rented = new List<Equipment>();
            List<int> ids = new List<int>();
            String sql = "SELECT * FROM rent_equipment WHERE VISITOR_VisitorID = @vid;";
            MySqlCommand command = new MySqlCommand(sql,dh.connection);
            try
            {
                dh.connection.Open();
                int visitorid = dh.GetvisitorID(rfidtag);

                command.Parameters.AddWithValue("@vid", visitorid);
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
                dh.connection.Close();
            }
            return rented;
        }
        private List<Equipment> PrivateGetListEquipment(List<int> ids)
        {
            List<Equipment> rented = new List<Equipment>();

            foreach (int i in ids)
            {
                String sql1 = "SELECT * FROM equipment WHERE EquipmentID = " + i + ";";
                MySqlCommand command1 = new MySqlCommand(sql1, dh.connection);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    int id = Convert.ToInt32(reader1[0]);
                    string itemname = reader1[1].ToString();
                    double price = Convert.ToDouble(reader1[2]);
                    string desc = reader1[3].ToString();

                    Equipment e = new Equipment(id, price, desc);
                    e.ItemName = itemname;
                    rented.Add(e);
                }
                reader1.Close();

            }
            return rented;

        }

        public bool ReturnAll(List<Equipment> tobereturned)
        {
            
            bool x = true;
            try
            {
                dh.connection.Open();
                int visitorid = dh.GetvisitorID(rfidtag);
                foreach (Equipment i in tobereturned)
                {
                    DateTime date = DateTime.Now;
                    //get rent id, use foreach, because it might be a list
                    //String sql1 = "SELECT * FROM rent_equipment WHERE VISITOR_VisitorID = " + visitorid + " AND `EQUIPMENT_EquipmentID` = " + i.EquipmentID + ";";
                    //MySqlCommand command1 = new MySqlCommand(sql1, dh.connection);
                    //MySqlDataReader reader = command1.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    if(DBNull.Value.Equals(reader[4]))
                    //    {
                    //        rentids.Add(Convert.ToInt32(reader[0]));
                    //    }
                            
                    //}
                    //reader.Close();
                    //foreach item in list update
                    foreach (var e in rentids)
                    {
                        String sql = "UPDATE rent_equipment SET EndDate = " + "'" + date.ToString("yyyy-MM-dd HH:mm:ss") + "'" + " WHERE RentID = " + e + ";";   
                        MySqlCommand command = new MySqlCommand(sql, dh.connection);

                        command.ExecuteNonQuery();
                    }
                    
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
                dh.connection.Close();
            }
            return x;
        }
        public bool ReturnSelected(int atindex)
        {
            DateTime date = DateTime.Now;   
            try
            {
                dh.connection.Open();
                int visitorid = dh.GetvisitorID(rfidtag);
                String sql = "UPDATE rent_equipment SET EndDate = " + "'" + date.ToString("yyyy-MM-dd HH:mm:ss") + "'" + "WHERE RentID = " + rentids[atindex] + ";";
                MySqlCommand command = new MySqlCommand(sql, dh.connection);
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
