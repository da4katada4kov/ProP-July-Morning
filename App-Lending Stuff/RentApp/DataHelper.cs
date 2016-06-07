﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cashapp
{
    class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339805;" +
                                    "user id=dbi339805;" +
                                    "password=1LD6XTYh06;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
        public int GetvisitorID(string rfid)
        {
            //PROBLEM MAICHE
            int visitorid;
            String sql = "SELECT VisitorID FROM visitor WHERE RFID = @rfid;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@rfid", rfid);
            try
            {
                visitorid = (int)command.ExecuteScalar();

                return visitorid;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }


        }
        private void UpdateVisitorBalance(int visitorid, double ordertotal)
        {
            String sql = "UPDATE `visitor` SET `Balance`=`Balance`- @total WHERE `VisitorID`= @visitorid;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@total", ordertotal);
            command.Parameters.AddWithValue("@visitorid", visitorid);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }
        public void Rent(string rfid, List<Equipment> products, double ordertotal)
        {
            try
            {
                connection.Open();
                int visitorid = GetvisitorID(rfid);
                foreach (var i in products)
                {
                    String sql = "INSERT INTO `rent_equipment`(`VISITOR_VisitorID`, `EQUIPMENT_EquipmentID`) VALUES (@visitorid, @equipmentid)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@equipmentid", i.EquipmentID);
                    command.Parameters.AddWithValue("@visitorid", visitorid);

                    command.ExecuteNonQuery();
                }
                UpdateVisitorBalance(visitorid, ordertotal);
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
