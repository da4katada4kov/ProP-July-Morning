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
            status = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            status.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            status.Location = new System.Drawing.Point(70, 140);
            status.BackColor = Color.Tomato;
            status.Text = "Show status";

            tbstatus = new TextBox();
            tbstatus.Width = 150;
            tbstatus.Location = new System.Drawing.Point(70, 110);

            label3.Text = "Visitor id:";
            this.label3.Location = new System.Drawing.Point(115, 79);

            this.Controls.Add(tbstatus);
            this.Controls.Add(status);

            lb = new ListBox();
            lb.Width = 185;
            lb.Height = 220;
            lb.Location = new System.Drawing.Point(270, 50);
            this.Controls.Add(lb);

            status.Click += GetVisitorStatus;
            
        }
        //private void ShowListBox()
        //{
        //    lb = new ListBox();
        //    lb.Width = 180;
        //    lb.Height = 220;
        //    lb.Location = new System.Drawing.Point(270, 50);
        //    this.Controls.Add(lb);
        //}
       
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
                    lb.Items.Add("Balance: " + vis.Balance);
                    if (vis.GuestOf != -1)
                    {
                        lb.Items.Add("At camping spot number: " + vis.GetCampingSpotId(vis));
                        if(vis.GuestOf!=vis.ID)
                            lb.Items.Add("Guest of visitor with id: " + vis.GuestOf);
                        else
                            lb.Items.Add("Paying for it himself");
                    }
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
        private void GetVisitorHistory(object sender, EventArgs e)
        {
            try
            {
                lb.Items.Clear();
                Visitor vis = v.GetVisitor(Convert.ToInt32(tbhistory.Text));
                if(vis!=null)
                {
                    int visitorid = Convert.ToInt32(tbhistory.Text);
                    double totalmoneyFromTransactions = v.GetTotalFromTransactions(visitorid);
                    double moneyonfood = v.GetMoneySpentOnFood(visitorid);
                    lb.Items.Add("Total money transfered:");
                    lb.Items.Add(totalmoneyFromTransactions);
                    lb.Items.Add("Money spent on food:");
                    lb.Items.Add(moneyonfood);
                }
                else
                {
                    lb.Items.Add("There is no such visitor");
                }
                
                
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void GetTotalBalance(object sender, EventArgs e)
        {
            //try
            //{
                lb.Items.Clear();
                double total = v.GetTotalBalance();
                lb.Items.Add("Total balance: " + total);


            //}
            //catch (Exception exc)
            //{
               // MessageBox.Show(exc.Message);
            //}
        }
        private void GetTotalMoneySpent(object sender, EventArgs e)
        {
            //try
            //{
                lb.Items.Clear();
                double onfood = v.GetTotalMoneySpentOnFood();
                int ontickets = v.GetTotalMoneySpentOnTickets();

                lb.Items.Add("Money spent on: ");
                lb.Items.Add("Tickets: " + ontickets);
                lb.Items.Add("Food: " + onfood);
            //}
            //catch (Exception exc)
            //{
                //MessageBox.Show(exc.Message);
            //}
        }
        private void visitorStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();

            //ShowListBox();

            status = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            status.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            status.Location = new System.Drawing.Point(70, 140);
            status.Text = "Show status";
            status.BackColor = Color.Tomato;

            tbstatus = new TextBox();
            tbstatus.Width = 150;
            tbstatus.Location = new System.Drawing.Point(70, 110);

            label3.Text = "Visitor id:";
            this.label3.Location = new System.Drawing.Point(115, 79);

            this.Controls.Add(tbstatus);
            this.Controls.Add(status);

            status.Click += GetVisitorStatus;
        }

        private void visitorHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();
            //ShowListBox();

            btnhistory = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            btnhistory.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            btnhistory.Location = new System.Drawing.Point(70, 140);
            btnhistory.Text = "Show history";
            btnhistory.BackColor = Color.Tomato;

            tbhistory = new TextBox();
            tbhistory.Width = 150;
            tbhistory.Location = new System.Drawing.Point(70, 110);

            label3.Text = "Visitor id:";
            this.label3.Location = new System.Drawing.Point(115, 79);

            this.Controls.Add(tbhistory);
            this.Controls.Add(btnhistory);
            btnhistory.Click += GetVisitorHistory;
        }

        private void totalBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();
            //ShowListBox();

            label3.Text = "What is the total balance of all visitors?";
            this.label3.Location = new System.Drawing.Point(15, 100);

            btncalculate = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            btncalculate.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            btncalculate.Location = new System.Drawing.Point(65, 140);
            btncalculate.Text = "Calculate";
            btncalculate.BackColor = Color.Tomato;

            this.Controls.Add(btncalculate);

            btncalculate.Click += GetTotalBalance;
        }

        private void totalMoneySpentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControls();
            //ShowListBox();

            label3.Text = "How much money were spent in total?";
            this.label3.Location = new System.Drawing.Point(20, 100);

            btncalculate = new Button();
            int widthOfAButton = 150, heightOfAButton = 60;
            btncalculate.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            btncalculate.Location = new System.Drawing.Point(65, 140);
            btncalculate.Text = "Calculate";
            btncalculate.BackColor = Color.Tomato;

            this.Controls.Add(btncalculate);

            btncalculate.Click += GetTotalMoneySpent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
