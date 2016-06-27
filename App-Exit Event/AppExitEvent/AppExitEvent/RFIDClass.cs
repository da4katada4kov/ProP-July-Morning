using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExitEvent
{
    public class RFIDClass
    {
        public string TagSerial { get; set; }
        private RFID myRFIDReader;
        private DataHelper dh;
        public RFIDClass()
        {
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new TagEventHandler(SayHello);
                dh = new DataHelper();
            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
            }
        }
        public void Open()
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException)
            {
                MessageBox.Show("no RFID-reader opened.");
            }
            
        }
        public void Close()
        {
            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();
           
        }
        //event handler
        public void SayHello(object sender, TagEventArgs e)
        {
            TagSerial = e.Tag;
            if (dh.CheckUser(TagSerial))
            {
                MessageBox.Show("You have logged out successfully!");
            }
            else
            {
                string result = "";
                List<string> rented = dh.GetAllRented();
                if (rented.Count>0)
                {
                    foreach (var i in rented)
                    {
                        result += i + "\n";
                    }
                    string caption = "You can't leave!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult dialogResult = MessageBox.Show("You have items to return!\n" + result + "\nIn order to leave you have to return all items!\nWould you like to do that?", caption, buttons);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (dh.ReturnAll())
                        {
                            if (dh.CheckUser(e.Tag))
                                MessageBox.Show("You have successfully logged out!");
                        }
                        else
                            MessageBox.Show("There was a problem with returning the equipment!");
                    }
                }
            }
        }
    }
}
