using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public class RentingStand
    {
        DataHelper dh = new DataHelper();
        public int ShopId { get; set; }
        public string Name { get; set; }
        private List<Equipment> products { get; set; }

        public RentingStand(int id)
        {
            this.ShopId = id;
            products = new List<Equipment>();
        }

        public List<Equipment> GetAllProducts()
        {
            String sql = "SELECT * FROM equipment;";
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
                    price = Convert.ToDouble(reader[2]);
                    description = reader[1].ToString();
                    products.Add(new Equipment(id, price, description));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the products");
            }
            finally
            {
                dh.connection.Close();
            }
            return products;
        }
        public Equipment GetProduct(string desc)
        {
            List<Equipment> temp = GetAllProducts();
            Equipment p = null;
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
