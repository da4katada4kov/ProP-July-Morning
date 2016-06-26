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

namespace app_for_status_of_event
{
    public partial class ShopStatus : Form
    {
        Shop s;
        public ShopStatus()
        {
            InitializeComponent();
            s = new Shop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxProductName.Text;
                int quantity = s.HowMuchWasSold(name);
                if (quantity != 0)
                    listBox1.Text = "The shop sold " + quantity + " units of " + name;
                else
                    listBox1.Text = "Product is not in inventory!";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonMoneyEarned_Click(object sender, EventArgs e)
        {
            try
            {
                double total = s.GetTotalMoneyEarnedInShop();
                listBox1.Text = "The shop earned " + total + " euros so far!";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void textBoxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }
    }
}
