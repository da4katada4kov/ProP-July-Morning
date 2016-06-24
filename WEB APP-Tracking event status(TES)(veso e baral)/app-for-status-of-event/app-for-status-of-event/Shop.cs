using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_for_status_of_event
{
    public class Shop
    {
        DataHelper dh = new DataHelper();
        public int HowMuchWasSold(string productname)
        {
            String sql = "SELECT SUM(`QuantityBought`) FROM `purchase_has_product` WHERE `PRODUCT_ProductID`=@id";
            int id = SearchForProduct(productname);
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            command.Parameters.AddWithValue("@id", id);
            int quantity = 0;
            try
            {
                dh.connection.Open();
                if (id != -1)
                {
                    string s = command.ExecuteScalar().ToString();
                    quantity = Convert.ToInt32(s);

                }
                else
                {
                   quantity = -1;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return quantity;
        }
        public int SearchForProduct(string productname)
        {
            int id=-1;
            String sql = "SELECT * FROM product WHERE Description = @name";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            command.Parameters.AddWithValue("@name", productname);
            try
            {
                dh.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id =Convert.ToInt32(reader[0]);
                }
                

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return id;
        }
        public double GetTotalMoneyEarnedInShop()
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
    }
}
