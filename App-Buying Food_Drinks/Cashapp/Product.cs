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
        public int ProductID { get; set; }      //Some propertise to keep the values
        public double PricePerOne { get; set; } //Some propertise to keep the values
        public string Description { get; set; } //Some propertise to keep the values
        public int QuantityBought {             
            get { return quantity; }
            set
            {
                if (value > 0)
                {
                   
                        quantity = value;

                }
                else
                {
                    quantity = 0; 
                }     
            } 
        }           //Some propertise to keep the values
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
        }        //Some propertise to keep the values

        public Product(int id, double price, string desc)//Construtor
        {
            this.ProductID = id;
            this.PricePerOne = price;
            this.Description = desc;
        }
        public override string ToString() //overrides the tostring method in the class
        {
            return Description + " - Quantity: " + QuantityBought;
        }

    }
}
