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
        public int ShopId { get; set; }   // some properties to keep the values
        public string Name { get; set; }  // some properties to keep the values
        private List<Product> products { get; set; } // private list of products

        public Shop(int id)//Constructor
        {
            this.ShopId = id;
            products = new List<Product>();
        }

        //retrieves all available products from the database and returns them in a list
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
                double price;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                    price = Convert.ToDouble(reader[1]);
                    description = reader[2].ToString();
                    products.Add(new Product(id, price, description));
                }
                reader.Close();
                foreach (var i in products)
                {
                    i.QuantityAvailable = GetAvailableQuantity(i.ProductID);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dh.connection.Close();
            }
            return products;
        }
        //retreives the available quantity of a specified product
        public int GetAvailableQuantity(int prodid) 
        {
            int quantity=0;
            String sql = "SELECT * FROM shop_has_product WHERE PRODUCT_ProductID = "+prodid+";";
            MySqlCommand command = new MySqlCommand(sql, dh.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantity = Convert.ToInt32(reader[2]);
            }
            reader.Close();
            if (quantity > 0)
                return quantity;
            else
                return 0;

        }
        public Product GetProduct(string desc) //Returns the product
        {
            List<Product> temp = GetAllProducts();
            Product p = null;
            foreach (var i in temp)
            {
                if (i.Description == desc)
                {
                    if (i.QuantityAvailable==0 || i.QuantityBought>=i.QuantityAvailable)
                        throw new ProductOutOfStockException();
                    else
                        p = i;
                }
            }

            if (p != null)
                return p;
            else
                return null; //if no product is found returns null
        }
    }
}
