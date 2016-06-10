using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AppExitEvent
{
    public partial class Form1 : Form
    {
        RFIDClass r;
        DataHelper ExitDataHelper;
        public Form1()
        {
            InitializeComponent();
            r = new RFIDClass();
            r.Open();
            ExitDataHelper = new DataHelper();
            Update();
        }
        private void UpdateForm()
        {
            textBoxId.Text = "";
            textBoxRfid.Text = "";
            
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            textBoxRfid.Text = r.TagSerial;
            if (textBoxId.Text != "" &&textBoxRfid.Text != "")
            {
                 if (ExitDataHelper.CheckUser(Convert.ToInt32(textBoxId.Text), textBoxRfid.Text))
            {
                MessageBox.Show("You have successfully logged out");
            }
            else
            {
                MessageBox.Show("Invelid combination of id and RFID \n Or You Have products to return.");
            }
            }
            else
            {
                MessageBox.Show("Invalid INPUT!");
            }
            
           
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }
    }
}
