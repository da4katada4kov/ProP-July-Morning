using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public class Visitor
    {
        private RFID myRFIDReader;
        public Visitor()
        {
            try
            {
                myRFIDReader = new RFID();               
                myRFIDReader.Tag += new TagEventHandler(SayHello);
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

        public void SayHello(object sender, TagEventArgs e)
        {
            DialogResult dialogResult =MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +
                ".\nThank you for your order ! ! !");
            if (dialogResult == DialogResult.OK)
                Close();
        }
    }
}
