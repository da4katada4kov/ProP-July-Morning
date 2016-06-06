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
        DataHelper dh = new DataHelper();

        private RFID myRFIDReader;
        public Order order;
        
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
            dh.AddProduct_PurchaseToDB(e.Tag, order.productlist, order.Total);
            DialogResult dialogResult =MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +
                ".\nYour order has been processed!");

                //Close();
                dh.connection.Close();

                
        }
    }
}
