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
    public partial class CheckInCamping : Form
    {
        Visitor v;
        int guestof;
        int spotid;
        public CheckInCamping()
        {
            InitializeComponent();
            listBox1.Text = "Please, identify yourself!";
            v = new Visitor();
            v.Open();
            v.myRFIDReader.Tag += new TagEventHandler(DisplayInfo);
        }

        private void CheckInCamping_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                v.Close();
            }
            catch
            {

            }
        }
        public void DisplayInfo(object sender, TagEventArgs e)
        {
            listBox1.Clear();          
            try
            {
                if (v.CheckUser(v.TagSerial, out guestof))
                {
                    spotid = v.GetSpotID(guestof);
                    listBox1.Text = "Hello!\nYou are at spot number " + spotid;
                }
                else
                {
                    listBox1.Text="You don't have a reserved camping spot!";
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            listBox1.Clear();
            try
            {
                //if rfid is scanned, checks the visitor in
                if (v.TagSerial != null)
                {
                    v.SpotEnter(spotid, guestof);
                    listBox1.Text = "You checked into the camping successfully!\nHave fun!";
                }
                else
                {
                    listBox1.Text = "You have not scanned your RFID!";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
