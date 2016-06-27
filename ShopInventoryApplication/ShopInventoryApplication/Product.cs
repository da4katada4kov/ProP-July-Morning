using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventoryApplication
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public int QuantityAvailable { get; set; }

        public Product(int id, string desc)
        {
            ProductID = id;
            Description = desc;
        }

        public override string ToString()
        {
            return Description + ", ID: " + ProductID + ", Quantity Available: " + QuantityAvailable;
        }
    }
}
