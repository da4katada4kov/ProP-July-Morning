using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            string name = textBoxProductName.Text;
            int quantity = s.HowMuchWasSold(name);
            if (quantity != -1)
                listBox1.Text = "The shop sold " + quantity + " " + name;
            else
                listBox1.Text ="Product is not in inventory!";
        }

        private void buttonMoneyEarned_Click(object sender, EventArgs e)
        {
            double total = s.GetTotalMoneyEarnedInShop();
            listBox1.Text="The shop earned " + total + " euros so far!";
        }
    }
}
