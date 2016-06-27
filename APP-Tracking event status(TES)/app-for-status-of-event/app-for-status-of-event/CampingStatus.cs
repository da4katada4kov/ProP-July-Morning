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

        //calls methods and displays infor about the camping
        private void buttonNrOfPeopleAtCamping_Click(object sender, EventArgs e)
        {
            try
            {
                int nrOfPplAtCamping = camping.GetNrOfPeopleAtCamping();
                int nrOfActiveSpots = camping.GetNrOfActiveSpots();
                int nrOfNonActiveSpots = camping.GetNrOfNonActiveSpots();
                listBox1.Items.Add("1 .Currently, there are " + nrOfPplAtCamping + " people at the");
                listBox1.Items.Add("camping!");
                listBox1.Items.Add("2. " +nrOfActiveSpots + " spots are active!");
                listBox1.Items.Add("3. Guests of the remaining " + nrOfNonActiveSpots + " spots still");
                listBox1.Items.Add("have not arrived!");

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
