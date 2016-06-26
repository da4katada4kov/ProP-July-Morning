using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChipSetApp
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void buttonBuyTicket_Click_1(object sender, EventArgs e)
        {
            BuyTicket buy = new BuyTicket();
            buy.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            EnterEvent enter = new EnterEvent();
            enter.Show();
        }
    }
}
