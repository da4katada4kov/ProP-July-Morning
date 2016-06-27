using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Camping_Entrance
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            //opens form for check in
            CheckInCamping checkin = new CheckInCamping();
            checkin.Show();
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            //opens form for checkout
            CheckOutCamping checkout = new CheckOutCamping();
            checkout.Show();
        }
    }
}
