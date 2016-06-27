using Phidgets.Events;
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
            //event whish is raised when the rfid is scanned, displays the tag serial in a label
            v.myRFIDReader.Tag += DisplayRFID;
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
                //if rfid is scanned, checks the visitor out
                if (v.TagSerial != null)
                {
                    if (v.CheckOut(v.TagSerial))
                        MessageBox.Show("You checked out successfully!");
                }
                else
                {
                    MessageBox.Show("You have not scanned your RFID!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //tag event handler
        public void DisplayRFID(object sender, TagEventArgs e)
        {
            label2.Text = v.TagSerial;
        }
    }
}
