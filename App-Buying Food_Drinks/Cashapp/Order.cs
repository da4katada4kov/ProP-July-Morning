using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashapp
{
    public class Order
    {
        public static int OrderID = 0;
        public List<Product> productlist { get; set; } //list of products a visitor has ordered
        public double Total { get; set; } //total saldo of purchase

        public Order()
        {
            OrderID++;
            productlist = new List<Product>();
        }
        //adds a product to the order
        public bool AddProduct(Product p)
        {
            bool x = true;
            foreach (Product prod in productlist)
            {
                if (prod.Description == p.Description)
                    x = false;
            }
            if (x == false)
            {
                GetProduct(p).QuantityBought += 1;
            }
            else
            {
                productlist.Add(p);
                p.QuantityBought += 1;
            }
            return x;
            
        }

        //searches for a product in the list
        public Product GetProduct(Product toGet)
        {
            Product p = null;
            foreach (var i in productlist)
            {
                if (i.Description== toGet.Description)
                    p = i;
            }

            if (p != null)
                return p;
            else
                return null;
        }
    }
}
