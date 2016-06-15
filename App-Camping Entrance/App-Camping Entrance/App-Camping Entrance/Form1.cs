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
    public partial class Form1 : Form
    {
        DataHelper verifyer;
        public Form1()
        {
            InitializeComponent();
            verifyer = new DataHelper();
            
        }

        private void buttonVerifyMainVisitor_Click(object sender, EventArgs e)
        {
            if (verifyer.CheckUser(Convert.ToInt32(textBoxHiredSpot.Text), Convert.ToInt32(textBoxMainVisitorId.Text)))
	{
        MessageBox.Show("Spot Verified!");
        textBoxMainVisitorId.Enabled = false;
        textBoxHiredSpot.Enabled = false;
        textBoxGuestId.Enabled = true;
        listBox1.Items.Add("SPOT ID: " + verifyer.HouseId.ToString());
        listBox1.Items.Add("Main Visitor ID: " + textBoxMainVisitorId.Text);
	}  
        }

        private void buttonVerifyGuest_Click(object sender, EventArgs e)
        {
            if (verifyer.CheckGuest(Convert.ToInt32(textBoxGuestId.Text)))
            {
                 MessageBox.Show("Spot Verified!");
                 listBox1.Items.Add("Guest ID: " + textBoxGuestId.Text);
                 textBoxGuestId.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong Id");
            }
        }

        private void buttonEnterCS_Click(object sender, EventArgs e)
        {
            textBoxMainVisitorId.Enabled = true;
            textBoxHiredSpot.Enabled = true;
            verifyer.VerifyEntranceForAll();
            MessageBox.Show("You Have Successfully Signed In");
            listBox1.Items.Clear();
           
            
        }
    }
}
