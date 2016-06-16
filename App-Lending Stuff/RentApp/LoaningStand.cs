using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public partial class LoaningStand : Form
    {
        public LoaningStand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rent rentform = new Rent();
            rentform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Return returnform = new Return();
            returnform.Show();
        }
    }
}
