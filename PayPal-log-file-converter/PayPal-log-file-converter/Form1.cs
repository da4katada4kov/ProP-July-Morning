using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayPal_log_file_converter
{
    public partial class Form1 : Form
    {
        OpenFileDialog od = new OpenFileDialog();
        LogFile lf;
        DataHelper dh = new DataHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //openfile dialog from which the user selects the file (.txt)
            if (od.ShowDialog() == DialogResult.OK)
            {
                //FileStream, StreamReader
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(od.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    lf = new LogFile();

                    lf.OrganizationBankAccount = Convert.ToInt32(sr.ReadLine());
                    string startdate = Convert.ToString(sr.ReadLine());
                    string enddate = Convert.ToString(sr.ReadLine());
                    lf.StartDate = DateTime.Parse(startdate);
                    lf.EndDate = DateTime.Parse(enddate);
                    lf.NrOfDeposits = Convert.ToInt32(sr.ReadLine());
                    int depositID = 0;
                    double amount = 0;
                    int visitorid = 0;
                    string s = sr.ReadLine();
                    

                    while (s != null)
                    {
                        string[] info = s.Split(' ');
                        depositID = Convert.ToInt32(info[0]);
                        amount =Convert.ToDouble(info[1]);
                        visitorid = Convert.ToInt32(info[2]);
                        Deposit d = new Deposit(depositID, amount, visitorid);

                        lf.AddDeposit(d);

                        s = sr.ReadLine();
                    }
                    //the file is then displayed in the listbox

                    listBox1.Items.Add("Organization Bank Account: "+lf.OrganizationBankAccount.ToString());
                    listBox1.Items.Add("From: " + lf.StartDate.ToString());
                    listBox1.Items.Add("To: " + lf.EndDate.ToString());
                    listBox1.Items.Add("Number of deposits: " + lf.NrOfDeposits);
                    foreach (var i in lf.deposits)
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Something went wrong.");
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (fs != null)
                        fs.Close();

                }
            }
          
        }

        private void buttonSaveToDB_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var i in lf.deposits)
                {
                    dh.AddLogToDatabase(i.IdNr, i.Amount, lf.EndDate, i.VisitorID);
                }
                dh.CloseConnection();
                listBox1.Items.Clear();
                listBox1.Items.Add("Successfully transferred data to DB!");
            }
            catch(Exception exc)
            {
                dh.CloseConnection();
                listBox1.Items.Clear();
                listBox1.Items.Add("This data already exist in the DB!");
                listBox1.Items.Add(exc.Message);               
            }
            
        }
    }
}
