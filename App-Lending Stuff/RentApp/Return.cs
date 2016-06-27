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
    public partial class Return : Form
    {
        VisitorReturn v = new VisitorReturn();
        List<Equipment> rented = new List<Equipment>();
        public Return()
        {
            InitializeComponent();
            toolTip2.SetToolTip(this.buttonReturnAll, "Return all rented items"); //tooltip
            toolTipselectone.SetToolTip(this.buttonReturnOne, "Press to return the item you have selected from the list");//tooltip
            v.Open();
            listBox1.Items.Add("Please, identify yourself!");
            v.myRFIDReader.Tag += DisplayRented; //attach event handler
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {
            
        }
        //event handler to display all rented by the visitor items
        private void DisplayRented(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            rented = v.GetAllRented();
            if (rented != null)
            {
                foreach (Equipment i in rented)
                {
                    listBox1.Items.Add(i.ItemName);
                }
            }
            else
            {
                listBox1.Items.Add("You have no rented items.");
            }
        }

        private void Return_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                v.Close();

            }
            catch
            {

            }
        }
        //calls method to return all rented items if the visitors specifies he wants to
        private void buttonReturnAll_Click(object sender, EventArgs e)
        {
            bool x = v.ReturnAll(rented);
            if (x == true)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("You successfully returned all items!");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("A problem occured!");
            }
        }
        //returns only the selected in the listbox item
        private void buttonReturnOne_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                bool x = v.ReturnSelected(index);
                listBox1.Items.Clear();
                if (x)
                    listBox1.Items.Add("You returned the " + rented[index].ItemName + " successfully!");
                else
                    listBox1.Items.Add("A problem occured!");
            }
            else
                MessageBox.Show("Please select in item from the list");

        }
    }
}
