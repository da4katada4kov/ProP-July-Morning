using Phidgets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public partial class ShopApp : Form
    {
        Shop shop1;
        Order order;
        Product p;
        Visitor v;
        DataHelper dh;
        double total = 0;
        public ShopApp()
        {
            InitializeComponent();
            shop1 = new Shop(1);
            v = new Visitor();
            List<Product> prods = shop1.GetAllProducts();
            order = new Order();
            dh = new DataHelper();
            toolTipOJ.SetToolTip(btnOJ, "Orange Juice");
            toolTipLJ.SetToolTip(buttonLJ, "Lemon Juice");
            toolTipCJ.SetToolTip(buttonCJ, "Cherry Juice");
            toolTipLimeJ.SetToolTip(buttonLimeJ, "Lime Juice");
            toolTipBurger.SetToolTip(btnBurger, "Chicken Burger");
            toolTipDonerKebab.SetToolTip(btnDoner, "Doner Kebab");
            toolTipFinlandia.SetToolTip(btnFinlandia, "Vodka Finlandia");
            toolTipFries.SetToolTip(btnFries, "French Fries");
            toolTipHotDog.SetToolTip(btnHotdog, "Hot Dog");
            toolTipNuts.SetToolTip(btnNuts, "Nuts");
            toolTipRum.SetToolTip(btnHavana, "Rum");
            toolTipSmirnoff.SetToolTip(btnSmirnoff, "Vodka Smirnoff");
            toolTipTequila.SetToolTip(btnJC, "Tequila");
            toolTipPizza.SetToolTip(btnPizza, "Pizza Slice");
            toolTipWhiskey.SetToolTip(btnJD, "Whiskey");
            
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
                foreach (var i in order.productlist)
                {                  
                        orderlist.Items.Add(i.ToString() );
                        total += i.PricePerOne * i.QuantityBought;
                    
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
                order.productlist[index].QuantityBought += 1;
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
                order.productlist[index].QuantityBought -= 1;

                if (order.productlist[index].QuantityBought == 0)
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
            try 
            {
                p = shop1.GetProduct("Sprite");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("CocaCola");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
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
            try
            {
                p = shop1.GetProduct("Fanta");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSchweppes_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Schweppes");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnRedBull_Click(object sender, EventArgs e)
        { 
            try
            {
                p = shop1.GetProduct("RedBull");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            try
            {
                p = shop1.GetProduct("Bavaria");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Jupiler");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            } 
        }

        private void button8_Click(object sender, EventArgs e)
        {           
            try
            {
                p = shop1.GetProduct("Heineken");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            } 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Corona");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Kameniza");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {           
            try
            {
                p = shop1.GetProduct("OrangeJuice");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSmirnoff_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Smirnoff");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("JackDaniels");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("HavanaClub");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Tequila");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Pizza");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Doner");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Fries");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Sandwich");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("HotDog");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Nuts");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
   
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
                    foreach (Product i in order.productlist)
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
                        btnCheckout.Text = "New Order";
                    }   

                }
            }
            else if (btnCheckout.Text == "New Order")
            {
                NewOrder();
                btnCheckout.Text = "Checkout";
            }
           
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Lemon Juice");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Cherry Juice");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                p = shop1.GetProduct("Lime Juice");
                AddNew();
            }
            catch (ProductOutOfStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                v.Close();
            }
            catch (PhidgetException)
            {
                //MessageBox.Show("RFID reader is not attached!");
            }
        }
    }
}
