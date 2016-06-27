using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChipSetApp
{
    public class Visitor
    {
        public string TagSerial { get; set; } //to get the RFID's Code
        public RFID myRFIDReader;
        public Visitor()
        {
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new TagEventHandler(SayHello);//assigns the event with the method
                
            }
            catch (PhidgetException)//If there is an error with the rfid it displays the message
            {
                MessageBox.Show("error at start-up.");
            }
            catch//General error catch
            {
                MessageBox.Show("Unexpected ERROR occured");
            }
        }
        public void Open() //Method to initialize the RFID
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
        public void Close()//Method to stop the RFID
        {
            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();
         
        }
        public void SayHello(object sender, TagEventArgs e)//Assigns the variable with the tag
        {
            TagSerial = e.Tag;
        }
       
    }
}
