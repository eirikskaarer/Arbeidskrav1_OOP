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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StartscreenCheckbox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.comboBoxBit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
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
            this.SendBtn = new System.Windows.Forms.Button();
            this.SaveToFileBtn = new System.Windows.Forms.Button();
            this.LoadConfigFromFileBtn = new System.Windows.Forms.Button();
            this.ReadCurrentConfigBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SaveBtnDatabase = new System.Windows.Forms.Button();
            this.AlarmStatusLbl = new System.Windows.Forms.Label();
            this.AlarmStatusTextLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MonitorList = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Commando = new System.Windows.Forms.TextBox();
            this.ReadScaledBtn = new System.Windows.Forms.Button();
            this.StopMonitoringBtn = new System.Windows.Forms.Button();
            this.ReadRawBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SerialStatusTextBox = new System.Windows.Forms.TextBox();
            this.textBoxIndicator1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.RawTimer = new System.Windows.Forms.Timer(this.components);
            this.ScaledTimer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SerialStatusLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpParameters.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 721);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.AboutBtn);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.StartscreenCheckbox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1256, 695);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "RDC Menu";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(185, 237);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(169, 39);
            this.AboutBtn.TabIndex = 13;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "Connect to RDC";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Choose RDC ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "SoftSenseConf 2.0";
            // 
            // StartscreenCheckbox
            // 
            this.StartscreenCheckbox.FormattingEnabled = true;
            this.StartscreenCheckbox.Location = new System.Drawing.Point(185, 79);
            this.StartscreenCheckbox.Name = "StartscreenCheckbox";
            this.StartscreenCheckbox.Size = new System.Drawing.Size(169, 21);
            this.StartscreenCheckbox.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.DisconnectBtn);
            this.tabPage1.Controls.Add(this.ConnectBtn);
            this.tabPage1.Controls.Add(this.comboBoxBit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial port configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 25);
            this.label17.TabIndex = 10;
            this.label17.Text = "Instrument connection:";
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
            this.tabPage2.Controls.Add(this.label21);
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
            this.tabPage2.Controls.Add(this.SendBtn);
            this.tabPage2.Controls.Add(this.SaveToFileBtn);
            this.tabPage2.Controls.Add(this.LoadConfigFromFileBtn);
            this.tabPage2.Controls.Add(this.ReadCurrentConfigBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instrument configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(27, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(273, 25);
            this.label21.TabIndex = 51;
            this.label21.Text = "Instrument configuration:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "Alarm Upper :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "Alarm lower :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(328, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 48;
            this.label14.Text = "Upper value :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(324, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 18);
            this.label15.TabIndex = 47;
            this.label15.Text = "Lower value :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(312, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 18);
            this.label16.TabIndex = 46;
            this.label16.Text = "Serial number :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(467, 140);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(436, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "New Parameters : ";
            // 
            // textBoxLowerValue
            // 
            this.textBoxLowerValue.Location = new System.Drawing.Point(467, 247);
            this.textBoxLowerValue.Name = "textBoxLowerValue";
            this.textBoxLowerValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxLowerValue.TabIndex = 44;
            // 
            // textBoxUpperValue
            // 
            this.textBoxUpperValue.Location = new System.Drawing.Point(467, 190);
            this.textBoxUpperValue.Name = "textBoxUpperValue";
            this.textBoxUpperValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpperValue.TabIndex = 43;
            // 
            // textBoxAlarmLower
            // 
            this.textBoxAlarmLower.Location = new System.Drawing.Point(467, 309);
            this.textBoxAlarmLower.Name = "textBoxAlarmLower";
            this.textBoxAlarmLower.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmLower.TabIndex = 42;
            // 
            // textBoxAlarmUpper
            // 
            this.textBoxAlarmUpper.Location = new System.Drawing.Point(467, 368);
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
            this.grpParameters.Location = new System.Drawing.Point(673, 92);
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
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.Location = new System.Drawing.Point(390, 446);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(177, 53);
            this.SendBtn.TabIndex = 40;
            this.SendBtn.Text = "Send to instrument only";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SaveToFileBtn
            // 
            this.SaveToFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToFileBtn.Location = new System.Drawing.Point(32, 304);
            this.SaveToFileBtn.Name = "SaveToFileBtn";
            this.SaveToFileBtn.Size = new System.Drawing.Size(202, 64);
            this.SaveToFileBtn.TabIndex = 3;
            this.SaveToFileBtn.Text = "Save config to file";
            this.SaveToFileBtn.UseVisualStyleBackColor = true;
            this.SaveToFileBtn.Click += new System.EventHandler(this.SaveToFileBtn_Click_1);
            // 
            // LoadConfigFromFileBtn
            // 
            this.LoadConfigFromFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadConfigFromFileBtn.Location = new System.Drawing.Point(32, 194);
            this.LoadConfigFromFileBtn.Name = "LoadConfigFromFileBtn";
            this.LoadConfigFromFileBtn.Size = new System.Drawing.Size(202, 64);
            this.LoadConfigFromFileBtn.TabIndex = 2;
            this.LoadConfigFromFileBtn.Text = "Load config ";
            this.LoadConfigFromFileBtn.UseVisualStyleBackColor = true;
            this.LoadConfigFromFileBtn.Click += new System.EventHandler(this.LoadConfigFromFileBtn_Click_1);
            // 
            // ReadCurrentConfigBtn
            // 
            this.ReadCurrentConfigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadCurrentConfigBtn.Location = new System.Drawing.Point(32, 92);
            this.ReadCurrentConfigBtn.Name = "ReadCurrentConfigBtn";
            this.ReadCurrentConfigBtn.Size = new System.Drawing.Size(202, 64);
            this.ReadCurrentConfigBtn.TabIndex = 0;
            this.ReadCurrentConfigBtn.Text = "Read config from instrument";
            this.ReadCurrentConfigBtn.UseVisualStyleBackColor = true;
            this.ReadCurrentConfigBtn.Click += new System.EventHandler(this.ReadCurrentConfigBtn_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.SaveBtnDatabase);
            this.tabPage3.Controls.Add(this.AlarmStatusLbl);
            this.tabPage3.Controls.Add(this.AlarmStatusTextLbl);
            this.tabPage3.Controls.Add(this.SaveBtn);
            this.tabPage3.Controls.Add(this.MonitorList);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.Commando);
            this.tabPage3.Controls.Add(this.ReadScaledBtn);
            this.tabPage3.Controls.Add(this.StopMonitoringBtn);
            this.tabPage3.Controls.Add(this.ReadRawBtn);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.Chart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1256, 695);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Current values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(247, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Scaled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(27, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(205, 25);
            this.label23.TabIndex = 27;
            this.label23.Text = "Instrument values:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(29, 580);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 18);
            this.label19.TabIndex = 26;
            this.label19.Text = "Save as:";
            // 
            // SaveBtnDatabase
            // 
            this.SaveBtnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtnDatabase.Location = new System.Drawing.Point(207, 624);
            this.SaveBtnDatabase.Name = "SaveBtnDatabase";
            this.SaveBtnDatabase.Size = new System.Drawing.Size(131, 44);
            this.SaveBtnDatabase.TabIndex = 25;
            this.SaveBtnDatabase.Text = "Save to database";
            this.SaveBtnDatabase.UseVisualStyleBackColor = true;
            // 
            // AlarmStatusLbl
            // 
            this.AlarmStatusLbl.AutoSize = true;
            this.AlarmStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmStatusLbl.Location = new System.Drawing.Point(662, 389);
            this.AlarmStatusLbl.Name = "AlarmStatusLbl";
            this.AlarmStatusLbl.Size = new System.Drawing.Size(14, 20);
            this.AlarmStatusLbl.TabIndex = 24;
            this.AlarmStatusLbl.Text = "-";
            // 
            // AlarmStatusTextLbl
            // 
            this.AlarmStatusTextLbl.AutoSize = true;
            this.AlarmStatusTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmStatusTextLbl.Location = new System.Drawing.Point(662, 355);
            this.AlarmStatusTextLbl.Name = "AlarmStatusTextLbl";
            this.AlarmStatusTextLbl.Size = new System.Drawing.Size(105, 20);
            this.AlarmStatusTextLbl.TabIndex = 23;
            this.AlarmStatusTextLbl.Text = "Alarm Status:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(24, 624);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(131, 44);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save to CSV.";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MonitorList
            // 
            this.MonitorList.FormattingEnabled = true;
            this.MonitorList.Location = new System.Drawing.Point(805, 354);
            this.MonitorList.Name = "MonitorList";
            this.MonitorList.Size = new System.Drawing.Size(399, 173);
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
            this.ReadScaledBtn.Location = new System.Drawing.Point(24, 187);
            this.ReadScaledBtn.Name = "ReadScaledBtn";
            this.ReadScaledBtn.Size = new System.Drawing.Size(195, 44);
            this.ReadScaledBtn.TabIndex = 17;
            this.ReadScaledBtn.Text = "Start monitoring";
            this.ReadScaledBtn.UseVisualStyleBackColor = true;
            this.ReadScaledBtn.Click += new System.EventHandler(this.ReadScaledBtn_Click);
            // 
            // StopMonitoringBtn
            // 
            this.StopMonitoringBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopMonitoringBtn.Location = new System.Drawing.Point(24, 287);
            this.StopMonitoringBtn.Name = "StopMonitoringBtn";
            this.StopMonitoringBtn.Size = new System.Drawing.Size(195, 44);
            this.StopMonitoringBtn.TabIndex = 15;
            this.StopMonitoringBtn.Text = "Stop monitoring";
            this.StopMonitoringBtn.UseVisualStyleBackColor = true;
            this.StopMonitoringBtn.Click += new System.EventHandler(this.StopMonitoringBtn_Click_1);
            // 
            // ReadRawBtn
            // 
            this.ReadRawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadRawBtn.Location = new System.Drawing.Point(24, 389);
            this.ReadRawBtn.Name = "ReadRawBtn";
            this.ReadRawBtn.Size = new System.Drawing.Size(195, 44);
            this.ReadRawBtn.TabIndex = 14;
            this.ReadRawBtn.Text = "Read raw";
            this.ReadRawBtn.UseVisualStyleBackColor = true;
            this.ReadRawBtn.Click += new System.EventHandler(this.ReadRawBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1267, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(19, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(791, 42);
            this.Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Vba";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(413, 306);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart";
            // 
            // SerialStatusTextBox
            // 
            this.SerialStatusTextBox.Location = new System.Drawing.Point(337, 736);
            this.SerialStatusTextBox.Name = "SerialStatusTextBox";
            this.SerialStatusTextBox.Size = new System.Drawing.Size(132, 20);
            this.SerialStatusTextBox.TabIndex = 17;
            // 
            // textBoxIndicator1
            // 
            this.textBoxIndicator1.Location = new System.Drawing.Point(34, 738);
            this.textBoxIndicator1.Name = "textBoxIndicator1";
            this.textBoxIndicator1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIndicator1.Size = new System.Drawing.Size(19, 20);
            this.textBoxIndicator1.TabIndex = 7;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 738);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Connection status to instrument:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(540, 738);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 20);
            this.label22.TabIndex = 14;
            this.label22.Text = "Current RDC ID:";
            // 
            // SerialStatusLabel
            // 
            this.SerialStatusLabel.AutoSize = true;
            this.SerialStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialStatusLabel.Location = new System.Drawing.Point(342, 738);
            this.SerialStatusLabel.Name = "SerialStatusLabel";
            this.SerialStatusLabel.Size = new System.Drawing.Size(14, 20);
            this.SerialStatusLabel.TabIndex = 14;
            this.SerialStatusLabel.Text = "-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(687, 736);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 20);
            this.label24.TabIndex = 15;
            this.label24.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 774);
            this.Controls.Add(this.SerialStatusTextBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.SerialStatusLabel);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxIndicator1);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "SoftSenseConf v 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label AlarmStatusLbl;
        private System.Windows.Forms.Label AlarmStatusTextLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox StartscreenCheckbox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button SaveBtnDatabase;
        private System.Windows.Forms.Label SerialStatusLabel;
        private System.Windows.Forms.TextBox SerialStatusTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

