using System;
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
            p = shop1.GetProduct("Sprite");     

            AddNew();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("CocaCola");

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
            p = shop1.GetProduct("Fanta");

            AddNew();
        }

        private void btnSchweppes_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Schweppes");

            AddNew();
        }

        private void btnRedBull_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("RedBull");

            AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Bavaria");

            AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Jupiler");

            AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Heineken");

            AddNew();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Corona");

            AddNew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Kameniza");

            AddNew();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("OrangeJuice");

            AddNew();
        }

        private void btnSmirnoff_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Smirnoff");

            AddNew();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("JackDaniels");

            AddNew();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("HavanaClub");

            AddNew();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Tequila");

            AddNew();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Pizza");

            AddNew();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Doner");

            AddNew();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Fries");

            AddNew();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Sandwich");

            AddNew();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("HotDog");

            AddNew();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            p = shop1.GetProduct("Nuts");

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
                    orderlist.Items.Clear();
                    orderlist.Items.Add("Please identify yourself!");
                    v.order = order;
                    
                }
            }
           
            
        }
    }
}
