using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventoryApplication
{
    public partial class Inventory : Form
    {
        DataHelper dh;
        public Inventory()
        {
            InitializeComponent();
            dh = new DataHelper();
        }
        //displays a list of all items in the shop_has_product table
        private void buttonOverview_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                List<Product> products = dh.GetAllProducts();
                foreach (Product p in products)
                {
                    listBox1.Items.Add(p.ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //calls the restock method
        private void buttonRestock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBoxQuantity.Text == "" || textBoxProductName.Text == ""))
                {
                    string name = textBoxProductName.Text;
                    int quantity = Convert.ToInt32(textBoxQuantity.Text);
                    if (dh.ReStock(name, quantity))
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Successful!");
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //validation
        private void textBoxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }
    }
}
