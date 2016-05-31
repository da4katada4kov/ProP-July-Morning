using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_for_status_of_event
{
    public partial class VisitorStatus : Form
    {
        Button status, btnhistory, btncalculate;
        TextBox tbstatus, tbhistory;
        ListBox lb;
        Visitor v;
        public VisitorStatus()
        {
            InitializeComponent();
            v = new Visitor();
            
        }
        private void ShowListBox()
        {
            lb = new ListBox();
            lb.Width = 180;
            lb.Height = 220;
            lb.Location = new System.Drawing.Point(270, 50);
            this.Controls.Add(lb);
        }
       
        private void RemoveControls()
        {
            if (this.Contains(status))
            {
                this.Controls.Remove(status);
                status.Dispose();
            }
            if (this.Contains(tbstatus))
            {
                this.Controls.Remove(tbstatus);
                tbstatus.Dispose();
            }
            if (this.Contains(tbhistory))
            {
                this.Controls.Remove(tbhistory);
                tbhistory.Dispose();
            }
            if (this.Contains(btnhistory))
            {
                this.Controls.Remove(btnhistory);
                btnhistory.Dispose();
            }
            if (this.Contains(label1))
            {
                this.Controls.Remove(label1);
                label1.Dispose();
            }
            if (this.Contains(label2))
            {
                this.Controls.Remove(label2);
                label2.Dispose();
            }
            if (this.Contains(pictureBox1))
            {
                this.Controls.Remove(pictureBox1);
                pictureBox1.Dispose();
            }
            if (this.Contains(btncalculate))
            {
                this.Controls.Remove(btncalculate);
                btncalculate.Dispose();
            }

        }
        private void GetVisitorStatus(object sender, EventArgs e)
        {
            try
            {
                lb.Items.Clear();
                Visitor vis = v.GetVisitorStatus(Convert.ToInt32(tbstatus.Text));
                if (vis != null)
                {
                    lb.Items.Add("ID: " + tbstatus.Text);
                    lb.Items.Add(vis.FirstName + " " + vis.LastName);
                    if(vis.Active==1)
                        lb.Items.Add("Currently at the event.");
                    else
                        lb.Items.Add("Currently not at the event.");
                }     
                else
                    lb.Items.Add("There is no such visitor.");
            }
                
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number.");
            }
        }
     
        private void visitorStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();

            ShowListBox();

            status = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            status.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            status.Location = new System.Drawing.Point(70, 140);
            status.Text = "Show status";

            tbstatus = new TextBox();
            tbstatus.Width = 150;
            tbstatus.Location = new System.Drawing.Point(70, 110);

            label3.Text = "Visitor id: ";
            this.label3.Location = new System.Drawing.Point(115, 79);

            this.Controls.Add(tbstatus);
            this.Controls.Add(status);

            status.Click += GetVisitorStatus;
        }

        private void visitorHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();

            ShowListBox();

            btnhistory = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            btnhistory.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            btnhistory.Location = new System.Drawing.Point(70, 140);
            btnhistory.Text = "Show history";

            tbhistory = new TextBox();
            tbhistory.Width = 150;
            tbhistory.Location = new System.Drawing.Point(70, 110);

            label3.Text = "Visitor id: ";
            this.label3.Location = new System.Drawing.Point(115, 79);

            this.Controls.Add(tbhistory);
            this.Controls.Add(btnhistory);
        }

        private void totalBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();
            ShowListBox();

            label3.Text = "What is the total balance of all visitors?";
            this.label3.Location = new System.Drawing.Point(15, 100);

            btncalculate = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            btncalculate.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            btncalculate.Location = new System.Drawing.Point(65, 140);
            btncalculate.Text = "Calculate";

            this.Controls.Add(btncalculate);
        }

        private void totalMoneySpentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();
            ShowListBox();

            label3.Text = "How much money were spent in total?";
            this.label3.Location = new System.Drawing.Point(20, 100);

            btncalculate = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            btncalculate.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            btncalculate.Location = new System.Drawing.Point(65, 140);
            btncalculate.Text = "Calculate";

            this.Controls.Add(btncalculate);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
