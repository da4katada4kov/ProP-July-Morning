using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashapp
{
    public class Visitor
    {
        DataHelper dh = new DataHelper();//dataelper object

        private RFID myRFIDReader;
        public Order order;
        
        public Visitor()
        {
            try
            {
                myRFIDReader = new RFID();               
                myRFIDReader.Tag += new TagEventHandler(ProcessOrder);
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
        // processes the order and calls the method for generating a sales receipt
        public void ProcessOrder(object sender, TagEventArgs e)
        {
            if (dh.AddProduct_PurchaseToDB(e.Tag, order.productlist, order.Total))
            {
                MessageBox.Show("Your order has been processed!");
                SaveReceipt(order.productlist);
            }

            dh.connection.Close();  
        }

        //generate a sales receipt and appends it to a log file
        private void SaveReceipt(List<Product> products)
        {
            FileStream fs = null;
            StreamWriter sr = null;
            try
            {
                fs = new FileStream("receipts.txt", FileMode.Append, FileAccess.Write);
                sr = new StreamWriter(fs);
                sr.WriteLine(DateTime.Now.ToString());
                foreach (Product i in products)
                {
                    sr.WriteLine(i.ToString() + " x " + i.PricePerOne.ToString() + "€");
                }
                sr.WriteLine("Total: " + order.Total.ToString());
                sr.WriteLine("---------------------------------");



            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
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
}
