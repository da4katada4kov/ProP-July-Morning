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
    public partial class CheckOutCamping : Form
    {
        Visitor v = new Visitor();
        public CheckOutCamping()
        {
            InitializeComponent();
            v.Open();
        }

        private void CheckOutCamping_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                v.Close();
            }
            catch
            {

            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (v.CheckOut(v.TagSerial))
                    MessageBox.Show("You checked out successfully!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
