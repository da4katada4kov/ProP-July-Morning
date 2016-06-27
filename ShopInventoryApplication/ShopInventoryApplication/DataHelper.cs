using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventoryApplication
{
    public class DataHelper
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

        //return list of products
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            String sql = "SELECT * FROM product";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string desc = reader[2].ToString();
                    Product p = new Product(id, desc);
                    products.Add(p);
                }
                reader.Close();
                foreach (Product p in products)
                {
                    p.QuantityAvailable = GetQuantity(p.ProductID);
                }
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return products;
        }
        //returns the quantity of a product with provided id
        private int GetQuantity(int productId)
        {
            String sql = "SELECT QuantityAvailable FROM shop_has_product WHERE PRODUCT_ProductID = " + productId;
            MySqlCommand command = new MySqlCommand(sql, connection);
            int quantity = 0;
            try
            {
                quantity = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

            return quantity;
        }
        //add specified quantity to a product with specified name
        public bool ReStock(string productName, int quantity)
        {
            bool x = false;
            String sql = "UPDATE `shop_has_product` SET `QuantityAvailable`=`QuantityAvailable` + @quantity WHERE `PRODUCT_ProductID`=@id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@quantity", quantity);
            try
            {
                connection.Open();
                int id = GetProductID(productName);
                command.Parameters.AddWithValue("@id", id);
                if (id != -1)
                {
                    command.ExecuteNonQuery();
                    x = true;
                }
                else
                {
                    x = false;
                }

            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return x;
        }
        //returns a product by descripton
        private int GetProductID(string description)
        {
            int id = -1;
            String sql = "SELECT ProductID FROM product WHERE Description = @description";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@description", description);
            try
            {
                id = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            return id;
        }
    }
}
