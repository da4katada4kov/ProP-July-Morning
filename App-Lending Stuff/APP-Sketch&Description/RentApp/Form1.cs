﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public partial class Form1 : Form
    {
        Shop shop1;
        Order order;
        Product p;
        Visitor v;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
            shop1 = new Shop(1);
            v = new Visitor();
            List<Product> prods = shop1.GetAllProducts();
            order = new Order();
            
        }
        //updates listbox, total cost of order 
        private void Update() 
        {
            int index = orderlist.SelectedIndex;

            orderlist.Items.Clear();
            total = 0;
            try
            {
                foreach (var i in order.productlist)
                {                  
                        orderlist.Items.Add(i.ToString() );
                        total += i.PricePerOne * i.Quantity;
                    
                }
                if(order.productlist.Count >0 )
                    orderlist.SelectedIndex = index;
                //update label total
                lblTotal.Text = total.ToString() + "€";
            }
            catch (IndexOutOfRangeException)
            {
                //MessageBox.Show("Please select an item from your order");
            }
            
        }
        //adds one to quantity
        private void AddOne()
        {
            try
            {
                int index = orderlist.SelectedIndex;
                order.productlist[index].Quantity += 1;
            }
            catch 
            {
                //MessageBox.Show("Please select an item from your order");
            }
            
        }
        //removes one from quantity
        private void RemoveOne()
        {
            try
            {
                int index = orderlist.SelectedIndex;
                order.productlist[index].Quantity -= 1;

                if (order.productlist[index].Quantity == 0)
                {
                    order.productlist.RemoveAt(index);
                    orderlist.SelectedIndex = -1;
                }
                    
            }
            catch
            {
                //MessageBox.Show("Please select an item from your order");
            }

        }
        //new product in order (when button is clicked)
        private void AddNew()
        {
            bool x = order.AddProduct(p);
            if (x == true)
                Update();
            else
            {
                AddOne();
                Update();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Laptop");     

            AddNew();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Camera");

            AddNew();
        }

        private void btnCalcPlus_Click(object sender, EventArgs e)
        {
            try
            {
                AddOne();
                Update();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCalcMinus_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveOne();
                Update();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("GoPro");

            AddNew();
        }

        private void btnSchweppes_Click(object sender, EventArgs e)
        {
            Product p = shop1.GetProduct("Tablet");

            AddNew();
        }

        private void btnRedBull_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("PortableSpeaker");

            AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Hoverboard");

            AddNew();
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("Your order is empty. Please, select a product.");
            }
            else
            {
                string info = "";
                foreach (Product i in order.productlist)
                {
                    info += i.ToString() + " x " + i.PricePerOne + "€\n";
                }
                info += "---------------------------------\n";
                info += "\t\tTotal: " + total + "€\n\n\nIs this order correct?";
                string caption = "Your order";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dialogResult=MessageBox.Show(info, caption,buttons);
                if (dialogResult == DialogResult.Yes)
                {
                    v.Open();
                    MessageBox.Show("Please, identify yourself in order to pay.");
                    
                }
                v.Close();
            }
           
            
        }
    }
}
