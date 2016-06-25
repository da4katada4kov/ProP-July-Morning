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
        private int available;
        public int ProductID { get; set; }
        public double PricePerOne { get; set; }
        public string Description { get; set; }
        public int QuantityBought {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
                else
                {
                    quantity = 0; 
                }     
            } 
        }
        public int QuantityAvailable 
        { 
            get { return available; }
            set
            {
                if (value > 0)
                    available = value;
                else
                {
                    available = 0;
                }
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
            return Description + " - Quantity: " + QuantityBought;
        }

    }
}
