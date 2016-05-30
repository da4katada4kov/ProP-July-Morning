using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashapp
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Product> productlist { get; set; }

        public Order()
        {
            OrderID++;
            productlist = new List<Product>();
        }

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
                GetProduct(p).Quantity += 1;
            }
            else
            {
                productlist.Add(p);
                p.Quantity += 1;
            }
            return x;
            
        }
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
