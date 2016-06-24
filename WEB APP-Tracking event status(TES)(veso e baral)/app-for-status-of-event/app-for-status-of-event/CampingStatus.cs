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
    public partial class CampingStatus : Form
    {
        Camping camping;
        public CampingStatus()
        {
            InitializeComponent();
            camping = new Camping();
        }

        private void buttonNrOfFreeSpots_Click(object sender, EventArgs e)
        {
            int freespots = camping.GetNrOfFreeSpots();
            listBox1.Items.Add("There are " + freespots + "/15 free spots at the camping.");
        }
    }
}
