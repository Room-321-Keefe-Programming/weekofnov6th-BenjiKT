namespace WeekOfNov6th
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
            this.lblTemperatureConverter = new System.Windows.Forms.Label();
            this.lblMoneyConvert = new System.Windows.Forms.Label();
            this.rdoTempConverter1 = new System.Windows.Forms.RadioButton();
            this.rdoTempConverter2 = new System.Windows.Forms.RadioButton();
            this.grpTempConverter = new System.Windows.Forms.GroupBox();
            this.cmbMoneyConverter = new System.Windows.Forms.ComboBox();
            this.btnTemp = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblDistanceConverter = new System.Windows.Forms.Label();
            this.chkMeterToInch = new System.Windows.Forms.CheckBox();
            this.chkMileToKilo = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.chkInchToMeter = new System.Windows.Forms.CheckBox();
            this.chkKiloToMiles = new System.Windows.Forms.CheckBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.nudInput1 = new System.Windows.Forms.NumericUpDown();
            this.nudInput2 = new System.Windows.Forms.NumericUpDown();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnMissle = new System.Windows.Forms.Button();
            this.rtbString = new System.Windows.Forms.RichTextBox();
            this.grpTempConverter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemperatureConverter
            // 
            this.lblTemperatureConverter.AutoSize = true;
            this.lblTemperatureConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureConverter.Location = new System.Drawing.Point(42, 68);
            this.lblTemperatureConverter.Name = "lblTemperatureConverter";
            this.lblTemperatureConverter.Size = new System.Drawing.Size(236, 26);
            this.lblTemperatureConverter.TabIndex = 0;
            this.lblTemperatureConverter.Text = "Temperature Converter";
            // 
            // lblMoneyConvert
            // 
            this.lblMoneyConvert.AutoSize = true;
            this.lblMoneyConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyConvert.Location = new System.Drawing.Point(42, 142);
            this.lblMoneyConvert.Name = "lblMoneyConvert";
            this.lblMoneyConvert.Size = new System.Drawing.Size(178, 26);
            this.lblMoneyConvert.TabIndex = 1;
            this.lblMoneyConvert.Text = "Money Converter";
            // 
            // rdoTempConverter1
            // 
            this.rdoTempConverter1.AutoSize = true;
            this.rdoTempConverter1.Location = new System.Drawing.Point(18, 31);
            this.rdoTempConverter1.Name = "rdoTempConverter1";
            this.rdoTempConverter1.Size = new System.Drawing.Size(196, 28);
            this.rdoTempConverter1.TabIndex = 2;
            this.rdoTempConverter1.TabStop = true;
            this.rdoTempConverter1.Text = "Celsuis - Fahrenheit";
            this.rdoTempConverter1.UseVisualStyleBackColor = true;
            // 
            // rdoTempConverter2
            // 
            this.rdoTempConverter2.AutoSize = true;
            this.rdoTempConverter2.Location = new System.Drawing.Point(234, 31);
            this.rdoTempConverter2.Name = "rdoTempConverter2";
            this.rdoTempConverter2.Size = new System.Drawing.Size(196, 28);
            this.rdoTempConverter2.TabIndex = 3;
            this.rdoTempConverter2.TabStop = true;
            this.rdoTempConverter2.Text = "Fahrenheit - Celsius";
            this.rdoTempConverter2.UseVisualStyleBackColor = true;
            // 
            // grpTempConverter
            // 
            this.grpTempConverter.Controls.Add(this.rdoTempConverter1);
            this.grpTempConverter.Controls.Add(this.rdoTempConverter2);
            this.grpTempConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTempConverter.Location = new System.Drawing.Point(321, 38);
            this.grpTempConverter.Name = "grpTempConverter";
            this.grpTempConverter.Size = new System.Drawing.Size(458, 77);
            this.grpTempConverter.TabIndex = 4;
            this.grpTempConverter.TabStop = false;
            this.grpTempConverter.Tag = "";
            this.grpTempConverter.Text = "Convert";
            // 
            // cmbMoneyConverter
            // 
            this.cmbMoneyConverter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneyConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneyConverter.FormattingEnabled = true;
            this.cmbMoneyConverter.Items.AddRange(new object[] {
            "Dollar - Yen",
            "Yen - Dollar",
            "Dollar - Pound",
            "Pound - Dollar",
            "Dollar - Euro ",
            "Euro - Dollar",
            "Dollar - Rupee",
            "Rupee - Dollar",
            "Dollar - Krone",
            "Krone - Dollar"});
            this.cmbMoneyConverter.Location = new System.Drawing.Point(321, 142);
            this.cmbMoneyConverter.Name = "cmbMoneyConverter";
            this.cmbMoneyConverter.Size = new System.Drawing.Size(169, 32);
            this.cmbMoneyConverter.TabIndex = 5;
            // 
            // btnTemp
            // 
            this.btnTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.Location = new System.Drawing.Point(846, 82);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(131, 33);
            this.btnTemp.TabIndex = 6;
            this.btnTemp.Text = "Convert temp";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(47, 478);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(964, 148);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(846, 149);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(131, 32);
            this.btnCash.TabIndex = 8;
            this.btnCash.Text = "Convert Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput1.Location = new System.Drawing.Point(43, 372);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(61, 24);
            this.lblInput1.TabIndex = 11;
            this.lblInput1.Text = "Input1";
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput2.Location = new System.Drawing.Point(317, 372);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(61, 24);
            this.lblInput2.TabIndex = 12;
            this.lblInput2.Text = "Input2";
            // 
            // lblDistanceConverter
            // 
            this.lblDistanceConverter.AutoSize = true;
            this.lblDistanceConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceConverter.Location = new System.Drawing.Point(42, 243);
            this.lblDistanceConverter.Name = "lblDistanceConverter";
            this.lblDistanceConverter.Size = new System.Drawing.Size(196, 25);
            this.lblDistanceConverter.TabIndex = 13;
            this.lblDistanceConverter.Tag = "";
            this.lblDistanceConverter.Text = "Distance Converter";
            // 
            // chkMeterToInch
            // 
            this.chkMeterToInch.AutoSize = true;
            this.chkMeterToInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeterToInch.Location = new System.Drawing.Point(569, 240);
            this.chkMeterToInch.Name = "chkMeterToInch";
            this.chkMeterToInch.Size = new System.Drawing.Size(167, 28);
            this.chkMeterToInch.TabIndex = 14;
            this.chkMeterToInch.Text = "Meters to Inches";
            this.chkMeterToInch.UseVisualStyleBackColor = true;
            // 
            // chkMileToKilo
            // 
            this.chkMileToKilo.AutoSize = true;
            this.chkMileToKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMileToKilo.Location = new System.Drawing.Point(321, 240);
            this.chkMileToKilo.Name = "chkMileToKilo";
            this.chkMileToKilo.Size = new System.Drawing.Size(186, 28);
            this.chkMileToKilo.TabIndex = 15;
            this.chkMileToKilo.Tag = "";
            this.chkMileToKilo.Text = "Miles to Kilometers";
            this.chkMileToKilo.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(815, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(162, 31);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "Convert Distance";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // chkInchToMeter
            // 
            this.chkInchToMeter.AutoSize = true;
            this.chkInchToMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInchToMeter.Location = new System.Drawing.Point(569, 290);
            this.chkInchToMeter.Name = "chkInchToMeter";
            this.chkInchToMeter.Size = new System.Drawing.Size(167, 28);
            this.chkInchToMeter.TabIndex = 17;
            this.chkInchToMeter.Text = "Inches to Meters";
            this.chkInchToMeter.UseVisualStyleBackColor = true;
            // 
            // chkKiloToMiles
            // 
            this.chkKiloToMiles.AutoSize = true;
            this.chkKiloToMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKiloToMiles.Location = new System.Drawing.Point(321, 290);
            this.chkKiloToMiles.Name = "chkKiloToMiles";
            this.chkKiloToMiles.Size = new System.Drawing.Size(186, 28);
            this.chkKiloToMiles.TabIndex = 18;
            this.chkKiloToMiles.Text = "Kilometers to Miles";
            this.chkKiloToMiles.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(815, 287);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(162, 31);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "Convert Distance";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // nudInput1
            // 
            this.nudInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nudInput1.Location = new System.Drawing.Point(47, 412);
            this.nudInput1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudInput1.Minimum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            -2147483648});
            this.nudInput1.Name = "nudInput1";
            this.nudInput1.Size = new System.Drawing.Size(173, 29);
            this.nudInput1.TabIndex = 21;
            // 
            // nudInput2
            // 
            this.nudInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nudInput2.Location = new System.Drawing.Point(321, 412);
            this.nudInput2.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.nudInput2.Minimum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            -2147483648});
            this.nudInput2.Name = "nudInput2";
            this.nudInput2.Size = new System.Drawing.Size(169, 29);
            this.nudInput2.TabIndex = 22;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTest.Location = new System.Drawing.Point(793, 349);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(184, 34);
            this.btnTest.TabIndex = 23;
            this.btnTest.Text = "The missle Knows";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnMissle
            // 
            this.btnMissle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnMissle.Location = new System.Drawing.Point(794, 389);
            this.btnMissle.Name = "btnMissle";
            this.btnMissle.Size = new System.Drawing.Size(183, 31);
            this.btnMissle.TabIndex = 24;
            this.btnMissle.Text = "A Button this is";
            this.btnMissle.UseVisualStyleBackColor = true;
            this.btnMissle.Click += new System.EventHandler(this.btnMissle_Click);
            // 
            // rtbString
            // 
            this.rtbString.Location = new System.Drawing.Point(939, 158);
            this.rtbString.Name = "rtbString";
            this.rtbString.Size = new System.Drawing.Size(10, 10);
            this.rtbString.TabIndex = 25;
            this.rtbString.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 648);
            this.Controls.Add(this.btnMissle);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.nudInput2);
            this.Controls.Add(this.nudInput1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.chkKiloToMiles);
            this.Controls.Add(this.chkInchToMeter);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.chkMileToKilo);
            this.Controls.Add(this.chkMeterToInch);
            this.Controls.Add(this.lblDistanceConverter);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.cmbMoneyConverter);
            this.Controls.Add(this.grpTempConverter);
            this.Controls.Add(this.lblMoneyConvert);
            this.Controls.Add(this.lblTemperatureConverter);
            this.Controls.Add(this.rtbString);
            this.Name = "Form1";
            this.Text = " ";
            this.grpTempConverter.ResumeLayout(false);
            this.grpTempConverter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatureConverter;
        private System.Windows.Forms.Label lblMoneyConvert;
        private System.Windows.Forms.RadioButton rdoTempConverter1;
        private System.Windows.Forms.RadioButton rdoTempConverter2;
        private System.Windows.Forms.GroupBox grpTempConverter;
        private System.Windows.Forms.ComboBox cmbMoneyConverter;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblDistanceConverter;
        private System.Windows.Forms.CheckBox chkMeterToInch;
        private System.Windows.Forms.CheckBox chkMileToKilo;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckBox chkInchToMeter;
        private System.Windows.Forms.CheckBox chkKiloToMiles;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.NumericUpDown nudInput1;
        private System.Windows.Forms.NumericUpDown nudInput2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnMissle;
        private System.Windows.Forms.RichTextBox rtbString;
    }
}

