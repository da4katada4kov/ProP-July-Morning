using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashapp
{
    public class Product
    {
        private int quantity;
        public int ProductID { get; set; }
        public double PricePerOne { get; set; }
        public string Description { get; set; }
        public int Quantity {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
                else
                    quantity = 0;
            } 
        }

        public Product(int id, double price, string desc)
        {
            this.ProductID = id;
            this.PricePerOne = price;
            this.Description = desc;
        }
        public override string ToString()
        {
            return Description + " - Quantity: " + Quantity;
        }
    }
}
