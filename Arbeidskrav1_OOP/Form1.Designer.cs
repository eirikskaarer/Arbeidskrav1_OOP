﻿namespace Arbeidskrav1_OOP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxConStatSerial = new System.Windows.Forms.TextBox();
            this.textBoxIndicator1 = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBoxConfig = new System.Windows.Forms.TextBox();
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
            this.lblAlarmUpper = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlarmLower = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUpperValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLowerValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxConStatInstrument = new System.Windows.Forms.TextBox();
            this.textBoxIndicatorInstrument = new System.Windows.Forms.TextBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnConfigFromFile = new System.Windows.Forms.Button();
            this.btnCurrentConfig = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxConStatCurrent = new System.Windows.Forms.TextBox();
            this.textBoxIndicatorCurrent = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpParameters.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1326, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxConStatSerial);
            this.tabPage1.Controls.Add(this.textBoxIndicator1);
            this.tabPage1.Controls.Add(this.btnDisconnect);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.textBoxConfig);
            this.tabPage1.Controls.Add(this.comboBoxBit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1318, 827);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial port configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 706);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Connection status:";
            // 
            // textBoxConStatSerial
            // 
            this.textBoxConStatSerial.Location = new System.Drawing.Point(124, 703);
            this.textBoxConStatSerial.Name = "textBoxConStatSerial";
            this.textBoxConStatSerial.Size = new System.Drawing.Size(100, 20);
            this.textBoxConStatSerial.TabIndex = 8;
            // 
            // textBoxIndicator1
            // 
            this.textBoxIndicator1.Location = new System.Drawing.Point(239, 703);
            this.textBoxIndicator1.Name = "textBoxIndicator1";
            this.textBoxIndicator1.Size = new System.Drawing.Size(19, 20);
            this.textBoxIndicator1.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(42, 255);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(102, 33);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.Location = new System.Drawing.Point(42, 200);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 33);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.Location = new System.Drawing.Point(354, 60);
            this.textBoxConfig.Multiline = true;
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.Size = new System.Drawing.Size(308, 378);
            this.textBoxConfig.TabIndex = 4;
            // 
            // comboBoxBit
            // 
            this.comboBoxBit.FormattingEnabled = true;
            this.comboBoxBit.Location = new System.Drawing.Point(182, 126);
            this.comboBoxBit.Name = "comboBoxBit";
            this.comboBoxBit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bit rate";
            this.label2.UseMnemonic = false;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(182, 60);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 1;
            this.comboBoxPort.Click += new System.EventHandler(this.comboBoxPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 64);
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
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Controls.Add(this.textBoxConStatInstrument);
            this.tabPage2.Controls.Add(this.textBoxIndicatorInstrument);
            this.tabPage2.Controls.Add(this.btnSaveToFile);
            this.tabPage2.Controls.Add(this.btnConfigFromFile);
            this.tabPage2.Controls.Add(this.btnCurrentConfig);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1318, 827);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instrument configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(428, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "Alarm Upper :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(428, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "Alarm lower :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(430, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 48;
            this.label14.Text = "Upper value :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(426, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 18);
            this.label15.TabIndex = 47;
            this.label15.Text = "Lower value :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(461, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 18);
            this.label16.TabIndex = 46;
            this.label16.Text = "Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(569, 127);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(585, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "New Config : ";
            // 
            // textBoxLowerValue
            // 
            this.textBoxLowerValue.Location = new System.Drawing.Point(569, 234);
            this.textBoxLowerValue.Name = "textBoxLowerValue";
            this.textBoxLowerValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxLowerValue.TabIndex = 44;
            // 
            // textBoxUpperValue
            // 
            this.textBoxUpperValue.Location = new System.Drawing.Point(569, 177);
            this.textBoxUpperValue.Name = "textBoxUpperValue";
            this.textBoxUpperValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpperValue.TabIndex = 43;
            // 
            // textBoxAlarmLower
            // 
            this.textBoxAlarmLower.Location = new System.Drawing.Point(569, 296);
            this.textBoxAlarmLower.Name = "textBoxAlarmLower";
            this.textBoxAlarmLower.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmLower.TabIndex = 42;
            // 
            // textBoxAlarmUpper
            // 
            this.textBoxAlarmUpper.Location = new System.Drawing.Point(569, 355);
            this.textBoxAlarmUpper.Name = "textBoxAlarmUpper";
            this.textBoxAlarmUpper.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmUpper.TabIndex = 41;
            // 
            // grpParameters
            // 
            this.grpParameters.BackColor = System.Drawing.Color.Gainsboro;
            this.grpParameters.Controls.Add(this.lblCurrentConfig);
            this.grpParameters.Controls.Add(this.lblAlarmUpper);
            this.grpParameters.Controls.Add(this.label3);
            this.grpParameters.Controls.Add(this.lblAlarmLower);
            this.grpParameters.Controls.Add(this.label4);
            this.grpParameters.Controls.Add(this.lblUpperValue);
            this.grpParameters.Controls.Add(this.label5);
            this.grpParameters.Controls.Add(this.lblLowerValue);
            this.grpParameters.Controls.Add(this.label6);
            this.grpParameters.Controls.Add(this.lblName);
            this.grpParameters.Controls.Add(this.label7);
            this.grpParameters.Location = new System.Drawing.Point(783, 69);
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
            this.lblCurrentConfig.Size = new System.Drawing.Size(116, 20);
            this.lblCurrentConfig.TabIndex = 61;
            this.lblCurrentConfig.Text = "Current Config:";
            // 
            // lblAlarmUpper
            // 
            this.lblAlarmUpper.AutoSize = true;
            this.lblAlarmUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmUpper.Location = new System.Drawing.Point(247, 296);
            this.lblAlarmUpper.Name = "lblAlarmUpper";
            this.lblAlarmUpper.Size = new System.Drawing.Size(15, 20);
            this.lblAlarmUpper.TabIndex = 60;
            this.lblAlarmUpper.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Name :";
            // 
            // lblAlarmLower
            // 
            this.lblAlarmLower.AutoSize = true;
            this.lblAlarmLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmLower.Location = new System.Drawing.Point(247, 238);
            this.lblAlarmLower.Name = "lblAlarmLower";
            this.lblAlarmLower.Size = new System.Drawing.Size(15, 20);
            this.lblAlarmLower.TabIndex = 59;
            this.lblAlarmLower.Text = "-";
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
            // lblUpperValue
            // 
            this.lblUpperValue.AutoSize = true;
            this.lblUpperValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperValue.Location = new System.Drawing.Point(249, 175);
            this.lblUpperValue.Name = "lblUpperValue";
            this.lblUpperValue.Size = new System.Drawing.Size(15, 20);
            this.lblUpperValue.TabIndex = 58;
            this.lblUpperValue.Text = "-";
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
            // lblLowerValue
            // 
            this.lblLowerValue.AutoSize = true;
            this.lblLowerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerValue.Location = new System.Drawing.Point(247, 118);
            this.lblLowerValue.Name = "lblLowerValue";
            this.lblLowerValue.Size = new System.Drawing.Size(15, 20);
            this.lblLowerValue.TabIndex = 57;
            this.lblLowerValue.Text = "-";
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(247, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 20);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "-";
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
            this.label9.Location = new System.Drawing.Point(21, 708);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Connection status:";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(569, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 22);
            this.btnSend.TabIndex = 40;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // textBoxConStatInstrument
            // 
            this.textBoxConStatInstrument.Location = new System.Drawing.Point(122, 705);
            this.textBoxConStatInstrument.Name = "textBoxConStatInstrument";
            this.textBoxConStatInstrument.Size = new System.Drawing.Size(100, 20);
            this.textBoxConStatInstrument.TabIndex = 22;
            // 
            // textBoxIndicatorInstrument
            // 
            this.textBoxIndicatorInstrument.Location = new System.Drawing.Point(237, 705);
            this.textBoxIndicatorInstrument.Name = "textBoxIndicatorInstrument";
            this.textBoxIndicatorInstrument.Size = new System.Drawing.Size(19, 20);
            this.textBoxIndicatorInstrument.TabIndex = 21;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToFile.Location = new System.Drawing.Point(24, 258);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(202, 41);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // btnConfigFromFile
            // 
            this.btnConfigFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigFromFile.Location = new System.Drawing.Point(24, 168);
            this.btnConfigFromFile.Name = "btnConfigFromFile";
            this.btnConfigFromFile.Size = new System.Drawing.Size(202, 46);
            this.btnConfigFromFile.TabIndex = 2;
            this.btnConfigFromFile.Text = "Load config from file";
            this.btnConfigFromFile.UseVisualStyleBackColor = true;
            // 
            // btnCurrentConfig
            // 
            this.btnCurrentConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentConfig.Location = new System.Drawing.Point(24, 79);
            this.btnCurrentConfig.Name = "btnCurrentConfig";
            this.btnCurrentConfig.Size = new System.Drawing.Size(202, 46);
            this.btnCurrentConfig.TabIndex = 0;
            this.btnCurrentConfig.Text = "Load current config";
            this.btnCurrentConfig.UseVisualStyleBackColor = true;
            this.btnCurrentConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxConStatCurrent);
            this.tabPage3.Controls.Add(this.textBoxIndicatorCurrent);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1318, 827);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Current values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 706);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Connection status:";
            // 
            // textBoxConStatCurrent
            // 
            this.textBoxConStatCurrent.Location = new System.Drawing.Point(120, 703);
            this.textBoxConStatCurrent.Name = "textBoxConStatCurrent";
            this.textBoxConStatCurrent.Size = new System.Drawing.Size(100, 20);
            this.textBoxConStatCurrent.TabIndex = 11;
            // 
            // textBoxIndicatorCurrent
            // 
            this.textBoxIndicatorCurrent.Location = new System.Drawing.Point(235, 703);
            this.textBoxIndicatorCurrent.Name = "textBoxIndicatorCurrent";
            this.textBoxIndicatorCurrent.Size = new System.Drawing.Size(19, 20);
            this.textBoxIndicatorCurrent.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(43, 44);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(396, 287);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 5000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBoxConfig;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCurrentConfig;
        private System.Windows.Forms.Button btnConfigFromFile;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox textBoxIndicator1;
        private System.Windows.Forms.TextBox textBoxConStatSerial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxConStatInstrument;
        private System.Windows.Forms.TextBox textBoxIndicatorInstrument;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxConStatCurrent;
        private System.Windows.Forms.TextBox textBoxIndicatorCurrent;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSend;
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
        private System.Windows.Forms.Label lblAlarmUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlarmLower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUpperValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLowerValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label7;
    }
}

