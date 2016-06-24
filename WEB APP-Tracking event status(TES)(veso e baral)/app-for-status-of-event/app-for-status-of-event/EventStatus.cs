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
    public partial class EventStatus : Form
    {
        Event eventStatus; 
        public EventStatus()
        {
            InitializeComponent();
            eventStatus = new Event();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //ppl who will be at event
            int number = eventStatus.GetNrOfPplWhoWillVisitEvent();
            listBox1.Items.Clear();
            listBox1.Items.Add("People who will visit July Morning: " + number);

        }

        private void buttonPplAtEvent_Click(object sender, EventArgs e)
        {
            //ppl at the event i.e. Active=1
            int number = eventStatus.GetNrOfPplAtEvent();
            listBox1.Items.Clear();
            listBox1.Items.Add("People who are currently at July Morning: " + number);
        }

        private void buttonPplLeft_Click(object sender, EventArgs e)
        {
            //ppl who left i.e. Active=0
            int number = eventStatus.GetNrOfPplWhoLeft();
            listBox1.Items.Clear();
            listBox1.Items.Add("People who left July Morning: " + number);
        }
    }
}
