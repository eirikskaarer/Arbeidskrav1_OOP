using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Threading;

namespace Arbeidskrav1_OOP
{
    public partial class Form1 : Form
    {
        List<int> analogReading = new List<int>();
        List<DateTime> timeStamp = new List<DateTime>();

        List<float> scaledReading = new List<float>();
        List<DateTime> timeStampScaled = new List<DateTime>();

        public Form1()
        {
            InitializeComponent();
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxPort.Text = "--Select--";
            string[] bitRate = new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };  // Teksten med alternativene i nedtrekksmenyene til comboBoxPort og comboBoxBit

            comboBoxBit.Items.AddRange(bitRate);
            comboBoxBit.SelectedIndex = comboBoxBit.Items.IndexOf("9600");
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

            StatusTimer.Interval = 5000;// Timer status, slik at timer events sjekkes jevnlig (hvert 5 Sec)
            StatusTimer.Tick += new EventHandler(StatusTimer_Tick);

            RawTimer.Interval = 5000; // Timer event for read funksjonene
            RawTimer.Tick += new EventHandler(RawTimer_Tick);

            ScaledTimer.Interval = 5000;
            ScaledTimer.Tick += new EventHandler(ScaledTimer_Tick);
        }

        private void ScaledTimer_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readscaled");
            Thread.Sleep(500);
            getStatus();
        }

        private void RawTimer_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");
            serialPort1.WriteLine("readscaled");
            Thread.Sleep(500);
            getStatus();
        }

        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int iVab;
            float iVab_float;
         

            string RecievedData = ((SerialPort)sender).ReadLine();
            string[] recievedData = RecievedData.Split(';'); //denne må muligens endres?
            string[] separateParts = RecievedData.Split(';');
            textBox1.Invoke((MethodInvoker)delegate { textBox1.AppendText(separateParts[1] + "\r\n"); });

            if (separateParts[0] == "readstatus")
            {
                AlarmStatusLbl.Invoke((MethodInvoker)delegate
                {
                    if (separateParts[1].Trim() == "0")
                    {
                        AlarmStatusLbl.Text = "Ok";
                    }
                    if (separateParts[1].Trim() == "1")
                    {
                        AlarmStatusLbl.Text = "fail";
                    }
                    if (separateParts[1].Trim() == "2")
                    {
                        AlarmStatusLbl.Text = "Alarm lower";
                    }
                    if (separateParts[1].Trim() == "3")
                    {
                        AlarmStatusLbl.Text = "Alarm Upper";
                    }
                });
            }
            if (separateParts[0] == "readraw")
            {
                MonitorList.Invoke((MethodInvoker)delegate
                {
                    if (int.TryParse(separateParts[1], out iVab))
                    {
                        MonitorList.Items.Add("RawData" + "," + DateTime.Now.ToString("HH:mm:ss") + "," + recievedData[1] + "\n");
                        analogReading.Add(iVab);
                        timeStamp.Add(DateTime.Now);
                        textBox1.Invoke((MethodInvoker)delegate { Chart.Series["Vba"].Points.DataBindXY(timeStamp, analogReading); });
                        textBox1.Invoke((MethodInvoker)delegate { Chart.Invalidate(); });

                    }
                    else
                    {
                        MessageBox.Show("Not working, check status !");
                    }
                });
                getStatus();
            }
            //Read scaled
            if (separateParts[0] == "readscaled")
            {
                MonitorList.Invoke((MethodInvoker)delegate
                {
                    if (float.TryParse(separateParts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out iVab_float))
                    {
                        MonitorList.Items.Add("ScaleData" + "," + DateTime.Now.ToString("HH:mm:ss") + "," + recievedData[1] + "\n");
                        scaledReading.Add(iVab_float);
                        //DateTime now = DateTime.Now;
                        //string formattedTime = now.Hour + ":" + now.Minute + ":" + now.Second;
                        //DateTime convert = Convert.ToDateTime(formattedTime);
                        timeStamp.Add(DateTime.Now);
                        //timeStampScaled.Add(convert);
                        Chart.Series["Vba"].Points.DataBindXY(timeStamp, scaledReading);
                        Chart.Invalidate();
                    }
                });
                getStatus();
            }
            
            if (recievedData[0] == "readconf")
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    SerialNumberLBL.Text = recievedData[1];
                    UpperValueLBL.Text = recievedData[3];
                    LowerValueLBL.Text = recievedData[2];
                    AlarmUpperLBL.Text = recievedData[5];
                    AlarmLowerLBL.Text = recievedData[4];
                });

            }
            if (recievedData[0] == "writeconf")
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    if (RecievedData == "writeconf;0")  
                    {
                        MessageBox.Show("Wrong Password! Try again");
                    }
                    if (RecievedData == "writeconf;1")
                    {
                        MessageBox.Show("Correct Password! Instrument Configuration has been updated!");
                        serialPort1.WriteLine("readconf");
                    }
                });
            }
        }
        private void ConnectBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                serialPort1.PortName = comboBoxPort.Text;
                StatusTimer.Start();
                while (serialPort1.IsOpen) ;
                serialPort1.Open();
                MessageBox.Show("Connection established to " + comboBoxPort.Text);

                textBoxConStatInstrument.Clear();
                textBoxConStatInstrument.AppendText(" Connected ");
                textBoxIndicator1.BackColor = Color.Green; // grønn farge på indicator når den er connected
            }
            catch (Exception ex)
            {
                serialPort1.Close();
                if (ex is ArgumentException)
                {
                    StatusTimer.Stop();
                    SerialStatusTextBox.Clear();
                    MessageBox.Show("Cannot Connect! Port might be in use ");
                    SerialStatusTextBox.AppendText("Cant Connect!");
                    textBoxIndicator1.BackColor = Color.Red;
                }
                else if (ex is UnauthorizedAccessException)
                {
                    StatusTimer.Stop();
                    SerialStatusTextBox.Clear();
                    MessageBox.Show("Not connected. Port may be in use.");
                    textBoxIndicator1.BackColor = Color.Red;
                }
                else
                {
                    StatusTimer.Stop();
                    SerialStatusTextBox.Clear();
                    MessageBox.Show(ex.ToString());
                }
            }
        } // Connecter arduino til programmet
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            StatusTimer.Stop();
            MessageBox.Show(" Disconnected from " + comboBoxPort.Text);
            SerialStatusTextBox.Clear(); //Legg til clear på resten av tabs!!
            SerialStatusTextBox.AppendText("Disconnected");
            textBoxConStatInstrument.AppendText("Disconnected");
            textBoxIndicator1.BackColor = Color.Red;
        } // Disconecter arduino fra programmet

        private void getStatus()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readstatus");
            }
        }

        private void StatusTimer_Tick(object sender, EventArgs e)  // Timer for som sjekker tilkoblingsstatus
        {
            if (serialPort1.IsOpen)
            {
                SerialStatusTextBox.Clear();
                SerialStatusTextBox.AppendText("Connected");
                textBoxIndicator1.BackColor = Color.Green;

                textBoxConStatInstrument.Text = SerialStatusTextBox.Text;
                textBoxIndicatorInstrument.BackColor = Color.Green;
                
                textBoxConStatCurrent.Text = SerialStatusTextBox.Text;
                textBoxIndicatorCurrent.BackColor = Color.Green;

            }
            else if (serialPort1.IsOpen == false)
            {
                StatusTimer.Stop();
                MessageBox.Show("Connection is lost, try to reconnect USB ");
                SerialStatusTextBox.Clear();
                SerialStatusTextBox.AppendText("Disconected");
                textBoxIndicator1.BackColor = Color.Red;

                textBoxConStatInstrument.Text = SerialStatusTextBox.Text;
                textBoxIndicatorInstrument.BackColor = Color.Red;

                textBoxConStatCurrent.Text = SerialStatusTextBox.Text;
                textBoxIndicatorCurrent.BackColor = Color.Red;

            }
        }
        private string getNewSerial()
        {
            return textBoxName.Text;
        }
        private float getNewUpperValue()
        {
            return float.Parse(textBoxUpperValue.Text);
        }
        private float getNewLowerValue()
        {
            return float.Parse(textBoxLowerValue.Text);
        }
        private int getNewAlarmUpper()
        {
            return int.Parse(textBoxAlarmUpper.Text);
        }
        private int getNewAlarmLower()
        {
            return int.Parse(textBoxAlarmLower.Text);
        }
        
        private string ValidateText(string n, float lv, float uv, int al, int au) //Denne validerer teksten slik at 
        {
            if (n.Length == 0 || n.Length < 10 || n.Length > 10)
            {
                MessageBox.Show("Serial Number Lenght is invalid! It must be 10 characters!");
                return "";
            }
            if (lv < 0.0 || lv > 500.0)
            {
                MessageBox.Show("lower value is out of range 0.0 - 500");
                return "";
            }
            if (uv < 500.0 || uv > 1000.0)
            {
                MessageBox.Show("Upper value is out of range 500.0 - 1000.0");
                return "";
            }
            if (uv == lv)
            {
                MessageBox.Show("The upper and lower value cannot be the same!");
                return "";
            }
            if (al < 0.0 || al > 500.0)
            {
                MessageBox.Show("Alarm Lower is out of range 0.0 - 500.0");
                return "";
            }
            if (au > 1000.0)
            {
                MessageBox.Show("Alarm Upper is out of range 0.0 - 1000.0");
                return "";
            }
            if (au < al)
            {
                MessageBox.Show("Alarm Upper cannot be smaller than Alarm Lower!");
                return "";
            }
            if (au == al)
            {
                MessageBox.Show("Alarm Upper and Alarm Lower cannot be the same!");
                return "";
            }
            else
            {
                return ValidateText(n, lv, uv, al, au);
            }
        }

        private void ReadCurrentConfigBtn_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Current config loaded");
                serialPort1.WriteLine("readconf");
            }
            else
            {
                MessageBox.Show("Current config not loaded");
            }
        }// Henter current value fra arduino og poster i currrent parameters

        private void LoadConfigFromFileBtn_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader inputfile = new StreamReader(@filename);

                string text = inputfile.ReadLine();
                string[] splitelements = text.Split(';');
                textBoxName.Text = splitelements[0];
                textBoxLowerValue.Text = splitelements[2];
                textBoxUpperValue.Text = splitelements[1];
                textBoxAlarmUpper.Text = splitelements[4];
                textBoxAlarmLower.Text = splitelements[3];
            }
        }// Laster opp sist lagrede konfigurasjon fra fil
        private void SaveToFileBtn_Click_1(object sender, EventArgs e)
        {
            string n = SerialNumberLBL.Text;
             string uv = UpperValueLBL.Text;
            string lv = LowerValueLBL.Text;
            string al = AlarmLowerLBL.Text;
            string au = AlarmUpperLBL.Text;
            string[] viewconf = { n, uv, lv, al, au };
            string viewConf = string.Join(";", viewconf);

            SaveFileDialog saveConfigDialog = new SaveFileDialog();
            saveConfigDialog.Filter = "txt files (.ssc)|.ssc|All files (.)|.";
            if (saveConfigDialog.ShowDialog() == DialogResult.OK)
            {
                Stream s = File.Open(saveConfigDialog.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(s);
                {
                    sw.Write(viewConf);
                    sw.Close();
                }
            }
        } //Denne knappen lagrer current parameters til fil
        private void SendBtn_Click(object sender, EventArgs e)
        {
            string n = getNewSerial();
            float lv = getNewLowerValue();
            float uv = getNewUpperValue();
            int al = getNewAlarmLower();
            int au = getNewAlarmUpper();
            string sendAll = ValidateText(n, lv, uv, al, au);
            string passwordbox = Interaction.InputBox("Authentication is required to update instrument values. Please enter password:", "Authentication Required", "..", 10, 10);
            serialPort1.WriteLine("writeconf" + ">" + passwordbox + ">" + sendAll);

        }

        private void ReadRawBtn_Click(object sender, EventArgs e)
        {
            ScaledTimer.Stop();
            if (serialPort1.IsOpen)
            {
                Commando.Text = "readraw";
                Commando.ReadOnly = true;
                RawTimer.Start();

            }
            else
            {
                MessageBox.Show("Port is not open, try reconnecting");
            }
            label9.Text = "Raw Values";
        } //Reads and display raw verdier

        private void ReadScaledBtn_Click(object sender, EventArgs e)
        {
            RawTimer.Stop();
            if (serialPort1.IsOpen)
            {
                Commando.Text = "readscaled";
                Commando.ReadOnly = true;
                ScaledTimer.Start();

            }
            else
            {
                MessageBox.Show("Porten er ikke åpen");
            }
            label9.Text = "Scaled Values";
        } //Reads and display scaled verdier

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog SaveMonitoringDialog = new SaveFileDialog();
                SaveMonitoringDialog.Filter = "CSV file (.csv)|.csv|All files (.)|.";   //Data is saved to a .csv file that Excel or other spreadsheet software can open
                SaveMonitoringDialog.Title = "Save Monitoring Data";


                if (SaveMonitoringDialog.ShowDialog() == DialogResult.OK)
                {
                    string save;
                    Stream s = File.Open(SaveMonitoringDialog.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);
                    {

                        foreach (var item in MonitorList.Items)
                        {
                            save = item.ToString();
                            sw.Write(save);

                        }

                        sw.Close();
                    }
                    MessageBox.Show("File Saved Succesfully!");
                }
            }
        } //Lagrer verdiene som displayes

        private void StopMonitoringBtn_Click_1(object sender, EventArgs e)
        {
            RawTimer.Stop();
            ScaledTimer.Stop();

            DialogResult dialogResult = MessageBox.Show("Monitoring has ended. Would you like to save the data?", "", MessageBoxButtons.YesNo);
            //Program asks if user wants to save the monitoring data
            if (dialogResult == DialogResult.Yes)
            {
                SaveBtn_Click(sender, e);
            }
        }
    }
}
