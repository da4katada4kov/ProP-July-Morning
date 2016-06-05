using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public class Shop
    {
        DataHelper dh = new DataHelper();
        public int ShopId { get; set; }
        public string Name { get; set; }
        private List<Product> products { get; set; }

        public Shop(int id)
        {
            this.ShopId = id;
            products = new List<Product>();
        }

        public List<Product> GetAllProducts()
        {
            String sql = "SELECT * FROM product;";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            try
            {
                dh.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                string description;
                int id;
                double price; ;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                    price = Convert.ToDouble(reader[1]);
                    description = reader[2].ToString();
                    products.Add(new Product(id, price, description));
                }
            }
            catch(Exception exc)
            {
                //MessageBox.Show("error while loading the products");
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return products;
        }
        public Product GetProduct(string desc)
        {
            List<Product> temp = GetAllProducts();
            Product p = null;
            foreach (var i in temp)
            {
                if (i.Description == desc)
                    p = i;
            }

            if (p != null)
                return p;
            else
                return null;
        }
    }
}
