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
    public partial class Rent : Form
    {
        RentingStand shop1;
        Order order;
        Equipment p;
        Visitor v;
        double total = 0;
        public Rent()
        {
            InitializeComponent();
            shop1 = new RentingStand(1);
            v = new Visitor();
            List<Equipment> prods = shop1.GetAllProducts();
            order = new Order();
            toolTipCamera.SetToolTip(btnCamera, "Sony DSLR-A200");
            toolTipCharger.SetToolTip(btnPhoneCharger, "Universal phone charger");
            toolTipGoPro.SetToolTip(btnGoPro, "GoPro Session");
            toolTipHoverBoard.SetToolTip(btnHoverBoard, "Hover Board");
            toolTipLaptop.SetToolTip(btnLaptop, "Sony Vaio");
            toolTipSpeakers.SetToolTip(btnSpeaker, "Logitech Speakers");
            toolTipTablet.SetToolTip(btnTablet, "Tablet");
            toolTipUSB.SetToolTip(btnUSB, "USB Cable");
            toolTipLaptopCharger.SetToolTip(btnCharger, "Universal Laptop Charger");

        }
        private void NewOrder()
        {
            //todo-clear order and listbox after info was passed to DB
            orderlist.Items.Clear();
            order = new Order();
            total = 0;
            lblTotal.Text = total.ToString() + "€";
        }
        //updates listbox, total cost of order 
        private void Update() 
        {
            int index = orderlist.SelectedIndex;

            orderlist.Items.Clear();
            total = 0;
            try
            {
                foreach (var i in order.todisplay)
                {                  
                        orderlist.Items.Add(i.ToString() );
                        total += i.PricePerOne * i.Quantity;
                    
                }
                if(order.todisplay.Count >0 )
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
                order.todisplay[index].Quantity += 1;
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
                order.todisplay[index].Quantity -= 1;

                if (order.todisplay[index].Quantity == 0)
                {
                    order.todisplay.RemoveAt(index);
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
            bool x = order.AddToDisplay(p);
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

            order.AddProduct(p);
            AddNew();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Camera");
            order.AddProduct(p);
            AddNew();

        }

        private void btnCalcPlus_Click(object sender, EventArgs e)
        {
            try
            {
                order.AddProduct(p);
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
                int index = orderlist.SelectedIndex;
                order.productlist.RemoveAt(index);
                RemoveOne();
                Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item!");
            }
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("GoPro");
            order.AddProduct(p);
            AddNew();

        }

        private void btnSchweppes_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Tablet");
            order.AddProduct(p);
            AddNew();

        }

        private void btnRedBull_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("PortableSpeaker");
            order.AddProduct(p);
            AddNew();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Hoverboard");
            order.AddProduct(p);
            AddNew();

        }
        private void btnPhoneCharger_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Phone Charger");
            order.AddProduct(p);
            AddNew();

        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Laptop Charger");
            order.AddProduct(p);
            AddNew();

        }

        private void btnUSB_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("USB Cable");
            order.AddProduct(p);
            AddNew();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (btnCheckout.Text == "Checkout")
            {
                if (total == 0)
                {
                    MessageBox.Show("Your order is empty. Please, select a product.");
                }
                else
                {
                    string info = "";
                    foreach (Equipment i in order.todisplay)
                    {
                        info += i.ToString() + " x " + i.PricePerOne + "€\n";
                    }
                    info += "---------------------------------\n";
                    info += "\t\tTotal: " + total + "€\n\n\nIs this order correct?";
                    string caption = "Your order";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult dialogResult = MessageBox.Show(info, caption, buttons);
                    if (dialogResult == DialogResult.Yes)
                    {
                        v.Open();
                        orderlist.Items.Clear();
                        orderlist.Items.Add("Please identify yourself!");
                        order.Total = total;
                        v.order = order;
                    }
                    
                    btnCheckout.Text = "Next visitor";
                }
            }
            else if (btnCheckout.Text == "Next visitor")
            {
                NewOrder();
                btnCheckout.Text = "Checkout";
            }
           
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                v.Close();
            }
            catch
            {

            }
        }

        
    }
}
