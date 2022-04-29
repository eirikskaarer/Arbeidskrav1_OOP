namespace Arbeidskrav1_OOP
{
    partial class Instrument_select
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
            this.ChooseInstrumentIDComboBox = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ConnectInstrumentIDBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseInstrumentIDComboBox
            // 
            this.ChooseInstrumentIDComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseInstrumentIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseInstrumentIDComboBox.FormattingEnabled = true;
            this.ChooseInstrumentIDComboBox.Location = new System.Drawing.Point(72, 129);
            this.ChooseInstrumentIDComboBox.Name = "ChooseInstrumentIDComboBox";
            this.ChooseInstrumentIDComboBox.Size = new System.Drawing.Size(155, 21);
            this.ChooseInstrumentIDComboBox.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(32, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(245, 25);
            this.label23.TabIndex = 28;
            this.label23.Text = "Choose instrument ID:";
            // 
            // ConnectInstrumentIDBtn
            // 
            this.ConnectInstrumentIDBtn.Location = new System.Drawing.Point(72, 211);
            this.ConnectInstrumentIDBtn.Name = "ConnectInstrumentIDBtn";
            this.ConnectInstrumentIDBtn.Size = new System.Drawing.Size(155, 39);
            this.ConnectInstrumentIDBtn.TabIndex = 29;
            this.ConnectInstrumentIDBtn.Text = "Connect";
            this.ConnectInstrumentIDBtn.UseVisualStyleBackColor = true;
            this.ConnectInstrumentIDBtn.Click += new System.EventHandler(this.ConnectInstrumentIDBtn_Click);
            // 
            // Instrument_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 322);
            this.Controls.Add(this.ConnectInstrumentIDBtn);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.ChooseInstrumentIDComboBox);
            this.Name = "Instrument_select";
            this.Text = "Instrument_select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseInstrumentIDComboBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button ConnectInstrumentIDBtn;
    }
}