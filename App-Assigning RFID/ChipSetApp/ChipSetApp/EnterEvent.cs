using System;
using Phidgets;
using Phidgets.Events;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace ChipSetApp
{
    public partial class EnterEvent : Form
    {

        Visitor v;
        DataHelper verify;
        public EnterEvent()
        {
            InitializeComponent();
            v = new Visitor();
            verify = new DataHelper();
            v.Open();
            v.myRFIDReader.Tag += UpdateLabel;
        }
        private void UpdateForm()
        {
            tbEmail.Text = "";
            tbFirstName.Text = "";
            tbId.Text = "";
            tbLastName.Text = "";
            tbRFID.Text = "";
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            //Checks if all required fields contain the required information
            if (tbEmail.Text!= ""&&tbFirstName.Text!= ""&&tbId.Text!= ""&&tbLastName.Text!= "")
            {

                //Check the requirements
                        if (verify.CheckUser(Convert.ToInt32(tbId.Text), tbFirstName.Text, tbLastName.Text, tbEmail.Text))
                    {
                        MessageBox.Show("Visitor Found! \n Assigning chip...");
                            //If user exists calls the giver Method,
                            //which thanks to the assign method forwards the RFID value to the database
                        verify.RFIDgiver(Convert.ToInt32(tbId.Text), tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbRFID.Text);
                    }
                    else MessageBox.Show("Visitor not found");
                    }
            else //Otherwise asks the user to add them
            {
                MessageBox.Show("All fields are required!");
            }
            
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }

        private void EnterEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                v.Close();
            }
            catch
            {

            }
        }
        public void UpdateLabel(object sender, TagEventArgs e)
        {
            tbRFID.Text = v.TagSerial;
        }

    }
}
