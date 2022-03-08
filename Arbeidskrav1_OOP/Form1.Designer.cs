namespace Arbeidskrav1_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SerialStatusTextBox = new System.Windows.Forms.TextBox();
            this.textBoxIndicator1 = new System.Windows.Forms.TextBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.comboBoxBit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxLowerValue = new System.Windows.Forms.TextBox();
            this.textBoxUpperValue = new System.Windows.Forms.TextBox();
            this.textBoxAlarmLower = new System.Windows.Forms.TextBox();
            this.textBoxAlarmUpper = new System.Windows.Forms.TextBox();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.lblCurrentConfig = new System.Windows.Forms.Label();
            this.AlarmUpperLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlarmLowerLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpperValueLBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LowerValueLBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SerialNumberLBL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.textBoxConStatInstrument = new System.Windows.Forms.TextBox();
            this.textBoxIndicatorInstrument = new System.Windows.Forms.TextBox();
            this.SaveToFileBtn = new System.Windows.Forms.Button();
            this.LoadConfigFromFileBtn = new System.Windows.Forms.Button();
            this.ReadCurrentConfigBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MonitorList = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Commando = new System.Windows.Forms.TextBox();
            this.ReadScaledBtn = new System.Windows.Forms.Button();
            this.StopMonitoringBtn = new System.Windows.Forms.Button();
            this.ReadRawBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxConStatCurrent = new System.Windows.Forms.TextBox();
            this.textBoxIndicatorCurrent = new System.Windows.Forms.TextBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.RawTimer = new System.Windows.Forms.Timer(this.components);
            this.ScaledTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpParameters.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1334, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.SerialStatusTextBox);
            this.tabPage1.Controls.Add(this.textBoxIndicator1);
            this.tabPage1.Controls.Add(this.DisconnectBtn);
            this.tabPage1.Controls.Add(this.ConnectBtn);
            this.tabPage1.Controls.Add(this.comboBoxBit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1326, 827);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial port configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(140, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 25);
            this.label17.TabIndex = 10;
            this.label17.Text = "SoftSenseConf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 666);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Connection status:";
            // 
            // SerialStatusTextBox
            // 
            this.SerialStatusTextBox.Location = new System.Drawing.Point(29, 689);
            this.SerialStatusTextBox.Name = "SerialStatusTextBox";
            this.SerialStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SerialStatusTextBox.TabIndex = 8;
            // 
            // textBoxIndicator1
            // 
            this.textBoxIndicator1.Location = new System.Drawing.Point(135, 689);
            this.textBoxIndicator1.Name = "textBoxIndicator1";
            this.textBoxIndicator1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIndicator1.Size = new System.Drawing.Size(19, 20);
            this.textBoxIndicator1.TabIndex = 7;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(169, 301);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(121, 33);
            this.DisconnectBtn.TabIndex = 6;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConnectBtn.Location = new System.Drawing.Point(169, 241);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(121, 33);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click_1);
            // 
            // comboBoxBit
            // 
            this.comboBoxBit.FormattingEnabled = true;
            this.comboBoxBit.Location = new System.Drawing.Point(169, 183);
            this.comboBoxBit.Name = "comboBoxBit";
            this.comboBoxBit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bit rate";
            this.label2.UseMnemonic = false;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(169, 120);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port choice";
            this.label1.UseMnemonic = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBoxName);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBoxLowerValue);
            this.tabPage2.Controls.Add(this.textBoxUpperValue);
            this.tabPage2.Controls.Add(this.textBoxAlarmLower);
            this.tabPage2.Controls.Add(this.textBoxAlarmUpper);
            this.tabPage2.Controls.Add(this.grpParameters);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.SendBtn);
            this.tabPage2.Controls.Add(this.textBoxConStatInstrument);
            this.tabPage2.Controls.Add(this.textBoxIndicatorInstrument);
            this.tabPage2.Controls.Add(this.SaveToFileBtn);
            this.tabPage2.Controls.Add(this.LoadConfigFromFileBtn);
            this.tabPage2.Controls.Add(this.ReadCurrentConfigBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1326, 827);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instrument configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(317, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "Alarm Upper :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(317, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "Alarm lower :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 48;
            this.label14.Text = "Upper value :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(315, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 18);
            this.label15.TabIndex = 47;
            this.label15.Text = "Lower value :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(303, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 18);
            this.label16.TabIndex = 46;
            this.label16.Text = "Serial number :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(458, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(427, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "New Parameters : ";
            // 
            // textBoxLowerValue
            // 
            this.textBoxLowerValue.Location = new System.Drawing.Point(458, 188);
            this.textBoxLowerValue.Name = "textBoxLowerValue";
            this.textBoxLowerValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxLowerValue.TabIndex = 44;
            // 
            // textBoxUpperValue
            // 
            this.textBoxUpperValue.Location = new System.Drawing.Point(458, 131);
            this.textBoxUpperValue.Name = "textBoxUpperValue";
            this.textBoxUpperValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpperValue.TabIndex = 43;
            // 
            // textBoxAlarmLower
            // 
            this.textBoxAlarmLower.Location = new System.Drawing.Point(458, 250);
            this.textBoxAlarmLower.Name = "textBoxAlarmLower";
            this.textBoxAlarmLower.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmLower.TabIndex = 42;
            // 
            // textBoxAlarmUpper
            // 
            this.textBoxAlarmUpper.Location = new System.Drawing.Point(458, 309);
            this.textBoxAlarmUpper.Name = "textBoxAlarmUpper";
            this.textBoxAlarmUpper.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmUpper.TabIndex = 41;
            // 
            // grpParameters
            // 
            this.grpParameters.BackColor = System.Drawing.Color.Gainsboro;
            this.grpParameters.Controls.Add(this.lblCurrentConfig);
            this.grpParameters.Controls.Add(this.AlarmUpperLBL);
            this.grpParameters.Controls.Add(this.label3);
            this.grpParameters.Controls.Add(this.AlarmLowerLBL);
            this.grpParameters.Controls.Add(this.label4);
            this.grpParameters.Controls.Add(this.UpperValueLBL);
            this.grpParameters.Controls.Add(this.label5);
            this.grpParameters.Controls.Add(this.LowerValueLBL);
            this.grpParameters.Controls.Add(this.label6);
            this.grpParameters.Controls.Add(this.SerialNumberLBL);
            this.grpParameters.Controls.Add(this.label7);
            this.grpParameters.Location = new System.Drawing.Point(653, 16);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(348, 353);
            this.grpParameters.TabIndex = 24;
            this.grpParameters.TabStop = false;
            // 
            // lblCurrentConfig
            // 
            this.lblCurrentConfig.AutoSize = true;
            this.lblCurrentConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentConfig.Location = new System.Drawing.Point(22, 26);
            this.lblCurrentConfig.Name = "lblCurrentConfig";
            this.lblCurrentConfig.Size = new System.Drawing.Size(152, 20);
            this.lblCurrentConfig.TabIndex = 61;
            this.lblCurrentConfig.Text = "Current Parameters:";
            // 
            // AlarmUpperLBL
            // 
            this.AlarmUpperLBL.AutoSize = true;
            this.AlarmUpperLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmUpperLBL.Location = new System.Drawing.Point(247, 296);
            this.AlarmUpperLBL.Name = "AlarmUpperLBL";
            this.AlarmUpperLBL.Size = new System.Drawing.Size(15, 20);
            this.AlarmUpperLBL.TabIndex = 60;
            this.AlarmUpperLBL.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Serial number:";
            // 
            // AlarmLowerLBL
            // 
            this.AlarmLowerLBL.AutoSize = true;
            this.AlarmLowerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmLowerLBL.Location = new System.Drawing.Point(247, 238);
            this.AlarmLowerLBL.Name = "AlarmLowerLBL";
            this.AlarmLowerLBL.Size = new System.Drawing.Size(15, 20);
            this.AlarmLowerLBL.TabIndex = 59;
            this.AlarmLowerLBL.Text = "-";
            this.AlarmLowerLBL.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Lower value :";
            // 
            // UpperValueLBL
            // 
            this.UpperValueLBL.AutoSize = true;
            this.UpperValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperValueLBL.Location = new System.Drawing.Point(247, 120);
            this.UpperValueLBL.Name = "UpperValueLBL";
            this.UpperValueLBL.Size = new System.Drawing.Size(15, 20);
            this.UpperValueLBL.TabIndex = 58;
            this.UpperValueLBL.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Upper value :";
            // 
            // LowerValueLBL
            // 
            this.LowerValueLBL.AutoSize = true;
            this.LowerValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerValueLBL.Location = new System.Drawing.Point(247, 178);
            this.LowerValueLBL.Name = "LowerValueLBL";
            this.LowerValueLBL.Size = new System.Drawing.Size(15, 20);
            this.LowerValueLBL.TabIndex = 57;
            this.LowerValueLBL.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Alarm lower :";
            // 
            // SerialNumberLBL
            // 
            this.SerialNumberLBL.AutoSize = true;
            this.SerialNumberLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberLBL.Location = new System.Drawing.Point(247, 69);
            this.SerialNumberLBL.Name = "SerialNumberLBL";
            this.SerialNumberLBL.Size = new System.Drawing.Size(15, 20);
            this.SerialNumberLBL.TabIndex = 56;
            this.SerialNumberLBL.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Alarm Upper :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 659);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Connection status:";
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.Location = new System.Drawing.Point(458, 364);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(100, 22);
            this.SendBtn.TabIndex = 40;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // textBoxConStatInstrument
            // 
            this.textBoxConStatInstrument.Location = new System.Drawing.Point(24, 682);
            this.textBoxConStatInstrument.Name = "textBoxConStatInstrument";
            this.textBoxConStatInstrument.Size = new System.Drawing.Size(100, 20);
            this.textBoxConStatInstrument.TabIndex = 22;
            // 
            // textBoxIndicatorInstrument
            // 
            this.textBoxIndicatorInstrument.Location = new System.Drawing.Point(130, 682);
            this.textBoxIndicatorInstrument.Name = "textBoxIndicatorInstrument";
            this.textBoxIndicatorInstrument.Size = new System.Drawing.Size(19, 20);
            this.textBoxIndicatorInstrument.TabIndex = 21;
            // 
            // SaveToFileBtn
            // 
            this.SaveToFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToFileBtn.Location = new System.Drawing.Point(20, 137);
            this.SaveToFileBtn.Name = "SaveToFileBtn";
            this.SaveToFileBtn.Size = new System.Drawing.Size(202, 35);
            this.SaveToFileBtn.TabIndex = 3;
            this.SaveToFileBtn.Text = "Save to file";
            this.SaveToFileBtn.UseVisualStyleBackColor = true;
            this.SaveToFileBtn.Click += new System.EventHandler(this.SaveToFileBtn_Click_1);
            // 
            // LoadConfigFromFileBtn
            // 
            this.LoadConfigFromFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadConfigFromFileBtn.Location = new System.Drawing.Point(24, 208);
            this.LoadConfigFromFileBtn.Name = "LoadConfigFromFileBtn";
            this.LoadConfigFromFileBtn.Size = new System.Drawing.Size(202, 39);
            this.LoadConfigFromFileBtn.TabIndex = 2;
            this.LoadConfigFromFileBtn.Text = "Load config from file";
            this.LoadConfigFromFileBtn.UseVisualStyleBackColor = true;
            this.LoadConfigFromFileBtn.Click += new System.EventHandler(this.LoadConfigFromFileBtn_Click_1);
            // 
            // ReadCurrentConfigBtn
            // 
            this.ReadCurrentConfigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadCurrentConfigBtn.Location = new System.Drawing.Point(20, 61);
            this.ReadCurrentConfigBtn.Name = "ReadCurrentConfigBtn";
            this.ReadCurrentConfigBtn.Size = new System.Drawing.Size(202, 36);
            this.ReadCurrentConfigBtn.TabIndex = 0;
            this.ReadCurrentConfigBtn.Text = "Read current config";
            this.ReadCurrentConfigBtn.UseVisualStyleBackColor = true;
            this.ReadCurrentConfigBtn.Click += new System.EventHandler(this.ReadCurrentConfigBtn_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SaveBtn);
            this.tabPage3.Controls.Add(this.MonitorList);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.Commando);
            this.tabPage3.Controls.Add(this.ReadScaledBtn);
            this.tabPage3.Controls.Add(this.StopMonitoringBtn);
            this.tabPage3.Controls.Add(this.ReadRawBtn);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxConStatCurrent);
            this.tabPage3.Controls.Add(this.textBoxIndicatorCurrent);
            this.tabPage3.Controls.Add(this.Chart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1326, 827);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Current values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(32, 450);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(131, 44);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MonitorList
            // 
            this.MonitorList.FormattingEnabled = true;
            this.MonitorList.Location = new System.Drawing.Point(276, 100);
            this.MonitorList.Name = "MonitorList";
            this.MonitorList.Size = new System.Drawing.Size(318, 394);
            this.MonitorList.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(37, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "Write command:";
            // 
            // Commando
            // 
            this.Commando.Location = new System.Drawing.Point(32, 113);
            this.Commando.Name = "Commando";
            this.Commando.Size = new System.Drawing.Size(187, 20);
            this.Commando.TabIndex = 18;
            // 
            // ReadScaledBtn
            // 
            this.ReadScaledBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadScaledBtn.Location = new System.Drawing.Point(32, 198);
            this.ReadScaledBtn.Name = "ReadScaledBtn";
            this.ReadScaledBtn.Size = new System.Drawing.Size(131, 44);
            this.ReadScaledBtn.TabIndex = 17;
            this.ReadScaledBtn.Text = "Read scaled";
            this.ReadScaledBtn.UseVisualStyleBackColor = true;
            this.ReadScaledBtn.Click += new System.EventHandler(this.ReadScaledBtn_Click);
            // 
            // StopMonitoringBtn
            // 
            this.StopMonitoringBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopMonitoringBtn.Location = new System.Drawing.Point(32, 365);
            this.StopMonitoringBtn.Name = "StopMonitoringBtn";
            this.StopMonitoringBtn.Size = new System.Drawing.Size(131, 44);
            this.StopMonitoringBtn.TabIndex = 15;
            this.StopMonitoringBtn.Text = "Stop monitoring";
            this.StopMonitoringBtn.UseVisualStyleBackColor = true;
            this.StopMonitoringBtn.Click += new System.EventHandler(this.StopMonitoringBtn_Click_1);
            // 
            // ReadRawBtn
            // 
            this.ReadRawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadRawBtn.Location = new System.Drawing.Point(32, 279);
            this.ReadRawBtn.Name = "ReadRawBtn";
            this.ReadRawBtn.Size = new System.Drawing.Size(131, 44);
            this.ReadRawBtn.TabIndex = 14;
            this.ReadRawBtn.Text = "Read raw";
            this.ReadRawBtn.UseVisualStyleBackColor = true;
            this.ReadRawBtn.Click += new System.EventHandler(this.ReadRawBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 688);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(19, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 665);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Connection status:";
            // 
            // textBoxConStatCurrent
            // 
            this.textBoxConStatCurrent.Location = new System.Drawing.Point(25, 688);
            this.textBoxConStatCurrent.Name = "textBoxConStatCurrent";
            this.textBoxConStatCurrent.Size = new System.Drawing.Size(100, 20);
            this.textBoxConStatCurrent.TabIndex = 11;
            // 
            // textBoxIndicatorCurrent
            // 
            this.textBoxIndicatorCurrent.Location = new System.Drawing.Point(140, 688);
            this.textBoxIndicatorCurrent.Name = "textBoxIndicatorCurrent";
            this.textBoxIndicatorCurrent.Size = new System.Drawing.Size(19, 20);
            this.textBoxIndicatorCurrent.TabIndex = 10;
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(661, 100);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Vba";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(463, 394);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StatusTimer
            // 
            this.StatusTimer.Interval = 5000;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 851);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SoftSenseConf v 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpParameters.ResumeLayout(false);
            this.grpParameters.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBit;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ReadCurrentConfigBtn;
        private System.Windows.Forms.Button LoadConfigFromFileBtn;
        private System.Windows.Forms.Button SaveToFileBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.TextBox textBoxIndicator1;
        private System.Windows.Forms.TextBox SerialStatusTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxConStatInstrument;
        private System.Windows.Forms.TextBox textBoxIndicatorInstrument;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxConStatCurrent;
        private System.Windows.Forms.TextBox textBoxIndicatorCurrent;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLowerValue;
        private System.Windows.Forms.TextBox textBoxUpperValue;
        private System.Windows.Forms.TextBox textBoxAlarmLower;
        private System.Windows.Forms.TextBox textBoxAlarmUpper;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCurrentConfig;
        private System.Windows.Forms.Label AlarmUpperLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AlarmLowerLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UpperValueLBL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LowerValueLBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SerialNumberLBL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button StopMonitoringBtn;
        private System.Windows.Forms.Button ReadRawBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadScaledBtn;
        private System.Windows.Forms.Timer RawTimer;
        private System.Windows.Forms.Timer ScaledTimer;
        private System.Windows.Forms.TextBox Commando;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox MonitorList;
        private System.Windows.Forms.Button SaveBtn;
    }
}

