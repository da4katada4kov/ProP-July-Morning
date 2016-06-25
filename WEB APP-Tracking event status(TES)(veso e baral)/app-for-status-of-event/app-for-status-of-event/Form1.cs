using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_for_status_of_event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStatusVisitor_Click(object sender, EventArgs e)
        {
            VisitorStatus vs = new VisitorStatus();
            vs.Show();
        }

        private void buttonStatusCamping_Click(object sender, EventArgs e)
        {
            CampingStatus cs = new CampingStatus();
            cs.Show();
        }

        private void buttonStatusEvent_Click(object sender, EventArgs e)
        {
            EventStatus es = new EventStatus();
            es.Show();
        }

        private void buttonStatusShop_Click(object sender, EventArgs e)
        {
            ShopStatus ss = new ShopStatus();
            ss.Show();
        }
    }
}
