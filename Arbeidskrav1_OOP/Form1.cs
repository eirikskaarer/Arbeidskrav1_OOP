using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Denne gjør at += new DataReceivedEventHandler skjønner hva den driver med.
using System.IO; //
using System.Globalization;
using System.Diagnostics;


namespace Arbeidskrav1_OOP
{
    public partial class Form1 : Form
    {
        List<int> analogReading = new List<int>();
        List<string> timeStamp = new List<string>();

        public Form1()
        {
            // Teksten med alternativene i nedtrekksmenyene til comboBoxPort og comboBoxBit
            InitializeComponent();
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxPort.Text = "--Select--";
            string[] bitRate = new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };

            comboBoxBit.Items.AddRange(bitRate);
            comboBoxBit.SelectedIndex = comboBoxBit.Items.IndexOf("9600");
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

            //Timer status, slik at timer events sjekkes jevnlig (hvert 5sec)
            timerStatus.Interval = 5000;
            timerStatus.Tick += new EventHandler(timerStatus_Tick);

        }
        // Tab1 Serial Port Config funksjoner:
        private void comboBoxPort_Click(object sender, EventArgs e)
        {
            // Port Choice nedtrekksmeny; Da denne blir klikket på cleares den [her som click event]
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
        }
        private void comboBoxPort_MouseClick(object sender, MouseEventArgs e)
        {
            // Port Choice nedtrekksmeny; Da denne blir klikket på cleares den [her som mouse click]
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
        }
        // DataRecievedHandler
        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string RecievedData = ((SerialPort)sender).ReadLine();
            textBoxConfig.Invoke((MethodInvoker)delegate
            { textBoxConfig.AppendText("Recieved: " + RecievedData + "\r\n"); });
        }
        // Disconnect knappen - Serial port config tab
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timerStatus.Stop();
            MessageBox.Show(" Disconnected from " + comboBoxPort.Text);
            textBoxConfig.AppendText("Disconnected");
        }
        // Connect knappen - Serial port config tab

        private void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.Close();
                serialPort1.PortName = comboBoxPort.Text;
                timerStatus.Start();
                while (serialPort1.IsOpen) ;
                serialPort1.Open();
                MessageBox.Show("Connection established to " + comboBoxPort.Text);
                textBoxConfig.Clear();
                textBoxConfig.AppendText(" Connected ");
                textBoxIndicator1.BackColor = Color.Green; // farge på indicator


            }
            catch (Exception ex)
            {
                serialPort1.Close();
                if (ex is ArgumentException)
                {
                    MessageBox.Show("Ikke gyldig port valgt!");
                }
                else if (ex is UnauthorizedAccessException)
                {
                    MessageBox.Show("Not connected. Port may be in use.");
                    textBoxIndicator1.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(textBoxConfig.Text);
                string[] lines = { "X-value; Y-value", "10.0; 10.0", "11.0; 11.0" };
                StreamWriter outputFile = new StreamWriter(@"C:\tmp\Text1.tmp");
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
                outputFile.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendAllConfig();
        }

        private void SendAllConfig()
        {
            //string n = getCurrentName();
            float lv = getCurrentLowerValue();
            float uv = getCurrentUpperValue();
            int al = getCurrentAlarmLower();
            int au = getCurrentAlarmUpper();

           /* lblName.Text = n;
            lblLowerValue.Text = lv;
            lblUpperValue.Text = uv;
            lblAlarmLower.Text = al;
            lblAlarmUpper.Text = au;*/
        }

        private int getCurrentAlarmUpper()
        {
            throw new NotImplementedException();
        }

        private int getCurrentAlarmLower()
        {
            throw new NotImplementedException();
        }

        private float getCurrentUpperValue()
        {
            throw new NotImplementedException();
        }

        private float getCurrentLowerValue()
        {
            throw new NotImplementedException();
        }

        /*private string getCurrentName()
        {
         try
            {
                if (textBoxName.Text.Length == 0) return lblName();
            }
        }*/
        
        // Timer for som sjekker tilkoblingsstatus
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textBoxConStatSerial.Clear();
                textBoxConStatSerial.AppendText("Suksess");
                textBoxIndicator1.BackColor = Color.Green;

                textBoxConStatInstrument.Text = textBoxConStatSerial.Text; //Denne gjør at textboxen i Serial Taben arver texten fra Instrument
                textBoxIndicatorInstrument.BackColor = Color.Green; 
                
                    textBoxConStatCurrent.Text = textBoxConStatSerial.Text;

            }
            else if (serialPort1.IsOpen == false)

            {
                MessageBox.Show("Connection is lost, try to reconnect USB ");
                textBoxConStatSerial.Clear();
                textBoxConStatSerial.AppendText("Disconected");
                textBoxIndicator1.BackColor = Color.Red;

                timerStatus.Stop();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblUpperValue_Click(object sender, EventArgs e)
        {

        }
    }
}