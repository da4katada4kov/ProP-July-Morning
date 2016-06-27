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
        public List<Equipment> productlist { get; set; } //list to save to database
        public List<Equipment> todisplay { get; set; } //list to display to user
        public double Total { get; set; }

        public Order()
        {
            OrderID++;
            productlist = new List<Equipment>();
            todisplay = new List<Equipment>();
        }
        //adds to list for db
        public void AddProduct(Equipment p)
        {
            productlist.Add(p);
        }
        //adds to list for user display
        public bool AddToDisplay(Equipment p)
        {
            bool x = true;
            foreach (Equipment prod in todisplay)
            {
                if (prod.Description == p.Description)
                    x = false;
            }
            if (x == false)
            {
                GetProductToDisplay(p).Quantity += 1;
            }
            else
            {
                todisplay.Add(p);
                p.Quantity += 1;
            }
            return x;

        }
        //searches for a product in db list
        public Equipment GetProduct(Equipment toGet)
        {
            Equipment p = null;
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
        //searches for a product in list to display
        public Equipment GetProductToDisplay(Equipment toGet)
        {
            Equipment p = null;
            foreach (var i in todisplay)
            {
                if (i.Description == toGet.Description)
                    p = i;
            }

            if (p != null)
                return p;
            else
                return null;
        }
    }
}
