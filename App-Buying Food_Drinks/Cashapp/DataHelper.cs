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
        public int GetPurchaseID(int visitorid)
        {
            String sql = "SELECT PurchaseID FROM purchase WHERE Timestamp = @timestamp";
            String sql1 = "SELECT MIN(`Timestamp`) FROM `purchase` WHERE `VISITOR_VisitorID`=@visitorid";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            command1.Parameters.AddWithValue("@visitorid", visitorid);
            
            try
            {
                DateTime timestamp = (DateTime)command1.ExecuteScalar();
                command.Parameters.AddWithValue("@timestamp", timestamp);
                int purchaseid = (int)command.ExecuteScalar();

                return purchaseid;
            }
            
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        public void AddProduct_PurchaseToDB(string rfid, List<Product> products)
        {
            String sql = "INSERT INTO purchase(SHOP_ShopID, VISITOR_VisitorID) VALUES (@shopid, @visitorid)";           
            MySqlCommand command = new MySqlCommand(sql, connection);
            int visitorid = GetvisitorID(rfid);
            command.Parameters.AddWithValue("@shopid", 1);
            command.Parameters.AddWithValue("@visitorid", visitorid);
            
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                int purchaseid = GetPurchaseID(visitorid);
                foreach (var i in products)
                {
                    connection.Open();
                    String sql1 = "INSERT INTO purchase_has_product(PURCHASE_PurchaseID, PRODUCT_ProductID, QuantityBought) VALUES (@purchaseid, @productid, @quantity)";
                    MySqlCommand command1 = new MySqlCommand(sql1, connection);
                    command1.Parameters.AddWithValue("@purchaseid", purchaseid);
                    command1.Parameters.AddWithValue("@productid", i.ProductID);
                    command1.Parameters.AddWithValue("@quantity", i.Quantity);

                    command1.ExecuteNonQuery();

                }
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
       
        public int GetvisitorID(string rfid)
        {
            //PROBLEM MAICHE
            int visitorid;
            String sql = "SELECT VisitorID FROM visitor WHERE RFID = @rfid;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@rfid", rfid);
            try
            {
                connection.Open();
                visitorid = (int)command.ExecuteScalar();

                return visitorid;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}