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
    public partial class FormExitEvent : Form
    {
        RFIDClass r;
        DataHelper ExitDataHelper;
        public FormExitEvent()
        {
            InitializeComponent();
            r = new RFIDClass();
            r.Open();
            Update();
        }


        private void buttonLeave_Click(object sender, EventArgs e)
        {
                  
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();

            }
        }

        private void textBoxRfid_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormExitEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                r.Close();
            }
            catch
            {

            }
        }
    }
}
