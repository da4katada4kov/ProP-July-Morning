using System;
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
            try
            {
                String sql = "SELECT PurchaseID FROM purchase p WHERE VISITOR_VisitorID = @visitorid HAVING Timestamp IN (SELECT MIN(Timestamp) FROM purchase o WHERE p.VISITOR_VisitorID = o.VISITOR_VisitorID)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@visitorid", visitorid);
                int purchaseid = (int)command.ExecuteScalar();

                return purchaseid;
            }
            
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }
        }
        public void AddProduct_PurchaseToDB(string rfid, List<Product> products)
        {
            try
            {
            
                String sql = "INSERT INTO purchase(SHOP_ShopID, VISITOR_VisitorID) VALUES (@shopid, @visitorid)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                int visitorid = GetvisitorID(rfid);
                command.Parameters.AddWithValue("@shopid", 1);
                command.Parameters.AddWithValue("@visitorid", visitorid);            

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                int purchaseid = GetPurchaseID(visitorid);
                foreach (var i in products)
                {
                    String sql1 = "INSERT INTO purchase_has_product(PURCHASE_PurchaseID, PRODUCT_ProductID, QuantityBought) VALUES (@purchaseid, @productid, @quantity)";
                    MySqlCommand command1 = new MySqlCommand(sql1, connection);
                    command.Parameters.AddWithValue("@purchaseid", purchaseid);
                    command.Parameters.AddWithValue("@vproductid", i.ProductID);
                    command.Parameters.AddWithValue("@quantity", i.Quantity);

                    connection.Open();
                    command1.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }

        }
        public int GetvisitorID(string rfid)
        {
            //PROBLEM MAICHE 
            try
            {
                int visitorid;
                String sql = "SELECT VisitorID FROM visitor WHERE RFID = @rfid;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@rfid", rfid);
                visitorid = (int)command.ExecuteScalar();

                return visitorid;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return -1;
            }

        }
    }
}
