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
        public int CampingSpot { get; set; }
        public int GuestOf { get; set; }
        public Visitor()
        {
            GuestOf = -1;
        }
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
                    v.GuestOf = Convert.ToInt32(reader[7]);
                    v.Balance = Convert.ToDouble(reader[9]);                   
                }

                if (v.FirstName == null)
                    v = null;
                
            }
            catch(MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return v;
        }
        public Visitor GetVisitor(int visitorid)
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
                }

                if (v.FirstName == null)
                    v = null;

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return v;
        }
        public int GetCampingSpotId(Visitor v)
        {
            int spot = -1;
            try
            {
                dh.connection.Open();
                
                if (v.GuestOf != -1)
                {
                    String sql = "SELECT * FROM booking WHERE ID_main = '" + v.GuestOf + "';";
                    MySqlCommand command = new MySqlCommand(sql, dh.connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        spot = Convert.ToInt32(reader[0]);
                    }

                }
                
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return spot;
        }
        public double GetTotalFromTransactions(int visitorid)
        {
            double total = 0;
            String sql = "SELECT SUM(AmountDeposited) FROM transactions WHERE VISITOR_VisitorID = '" + visitorid + "';";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            Visitor v = new Visitor();
            try
            {
                dh.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] == DBNull.Value)
                        total = 0;
                    else
                        total = Convert.ToDouble(reader[0]);
                }


            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return total;
        }
        public double GetMoneySpentOnFood(int visitorid)
        {
            /*1. select sum(total) from  purchase*/
            string total;
            double totalonfood=0;
            String sql = "SELECT SUM(Total) FROM purchase WHERE VISITOR_VisitorID = '" + visitorid + "';";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                //total = command.ExecuteScalar().ToString();
                //if(total!=null)
                //    totalonfood = Convert.ToDouble(total);
                //if (totalonfood > 0)
                //    return totalonfood;
                //else
                //    return 0;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(!DBNull.Value.Equals(reader[0]))
                        totalonfood = Convert.ToDouble(reader[0]);
                }
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return totalonfood;
        }
        public double GetTotalBalance()
        {
            //get the sum of all Balances in the visitor table
            double totalbalance;
            String sql = "SELECT SUM(Balance) FROM visitor";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                totalbalance = (double)command.ExecuteScalar();

                return totalbalance;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }
            finally
            {
                dh.connection.Close();
            }
        }
        public double GetTotalMoneySpentOnFood()
        {
            double total;
            String sql = "SELECT SUM(Total) FROM purchase";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                total = (double)command.ExecuteScalar();

                return total;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }
            finally
            {
                dh.connection.Close();
            }
        }
        public int GetTotalMoneySpentOnTickets()
        {
            int total;
            string nrofvisitors;
            String sql = "SELECT COUNT(*) FROM visitor";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                nrofvisitors = command.ExecuteScalar().ToString();

                total =Convert.ToInt32(nrofvisitors) * 55;
                return total;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }
            finally
            {
                dh.connection.Close();
            }
        }

        private List<int> GetRentedEquipmentIds()
        {
            List<int> equipmentIds = new List<int>();
            String sql = "SELECT EQUIPMENT_EquipmentID FROM rent_equipment";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    equipmentIds.Add(Convert.ToInt32(reader[0]));
                }
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return equipmentIds;
        }
        public double GetTotalMoneySpentOnEquipment()
        {
            double total = 0;
            double result = 0;
            try
            {
                List<int> ids = GetRentedEquipmentIds();
                dh.connection.Open();
                foreach (int i in ids)
                {
                    String sql = "SELECT RentPrice FROM equipment WHERE EquipmentID = " + i;
                    MySqlCommand command = new MySqlCommand(sql, dh.connection);
                    result = (double)command.ExecuteScalar();
                    total += result;
                }

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return total;
        }
    }

    
}
