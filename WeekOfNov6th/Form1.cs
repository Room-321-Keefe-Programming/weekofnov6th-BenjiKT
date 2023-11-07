using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Converting Temps
        private void btnTemp_Click(object sender, EventArgs e)
        {
            // C to f
            if (rdoTempConverter1.Checked)
            {
                double output1 = (double)nudInput1.Value * 1.8 + 32;
                double output2 = (double)nudInput2.Value * 1.8 + 32;

                rtbOutput.Text += "Converting celsius to fahrenheit:" + Environment.NewLine + "Input 1 = " + output1 + "F" + Environment.NewLine + "Input 2 = " + output2 + "F" + Environment.NewLine;
            } 
            // f to c
            else
            {
                double input1 = (double)nudInput1.Value;
                double input2 = (double)nudInput2.Value;
                double output1 = Math.Round((input1 - 32) * 0.55555, 2, MidpointRounding.AwayFromZero);
                double output2 = Math.Round((input2 - 32) * 0.55555, 2, MidpointRounding.AwayFromZero);

                rtbOutput.Text += "Converting fahrenheit to celsius:" + Environment.NewLine + "Input 1 = " + output1 + "C" + Environment.NewLine + "Input 2 = " + output2 + "C" + Environment.NewLine;
            }
        }

        //Converting Cash (Made to mach google)
        private void btnCash_Click(object sender, EventArgs e)
        {
            // Dollar to Yen
            if(cmbMoneyConverter.Text == "Dollar - Yen")
            {
                double output1 = (double)nudInput1.Value * 149.758;
                double output2 = (double)nudInput2.Value * 149.758;

                rtbOutput.Text += "Converting Dollar to Yen:" + Environment.NewLine + "Input 1 = " + output1 + "Yen" + Environment.NewLine + "Input 2 = " + output2 + "Yen" + Environment.NewLine;
            }
            // Yen to Dollar
            else if (cmbMoneyConverter.Text == "Yen - Dollar")
            {
                double output1 = (double)nudInput1.Value * 0.006676771;
                double output2 = (double)nudInput2.Value * 0.006676771;

                rtbOutput.Text += "Converting Yen to Dollar:" + Environment.NewLine + "Input 1 = " + output1 + "Dollar" + Environment.NewLine + "Input 2 = " + output2 + "Dollar" + Environment.NewLine;
            }
            //Error
            else
            {
                rtbOutput.Text += "Error: Please choose convertions" + Environment.NewLine;
            }
        }

        //Converting distance (Made to mach google)
        private void btn1_Click(object sender, EventArgs e)
        {
            bool error = true;

            //M t0 km
            if (chkMileToKilo.Checked)
            {
                error = false;

                double output1 = (double)nudInput1.Value * 1.609344;
                double output2 = (double)nudInput2.Value * 1.609344;

                rtbOutput.Text += "Converting Miles to Kilometer:" + Environment.NewLine + "Input 1 = " + output1 + "km" + Environment.NewLine + "Input 2 = " + output2 + "km" + Environment.NewLine;
            }
            // m to in
            if (chkMeterToInch.Checked)
            {
                error = false;


                double output1 = (double)nudInput1.Value * 39.370078740157484848;
                double output2 = (double)nudInput2.Value * 39.370078740157484848;

                rtbOutput.Text += "Converting Meters to Inches:" + Environment.NewLine + "Input 1 = " + output1 + "In" + Environment.NewLine + "Input 2 = " + output2 + "In" + Environment.NewLine;
            }
            if (error == true)
            {
                rtbOutput.Text += "Error: Please choose convertions" + Environment.NewLine;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bool error = true;

            //km to M
            if (chkKiloToMiles.Checked)
            {
                error = false;

                double output1 = (double)nudInput1.Value * 0.621371192;
                double output2 = (double)nudInput2.Value * 0.621371192;

                rtbOutput.Text += "Converting Kilometers to Miles:" + Environment.NewLine + "Input 1 = " + output1 + "M" + Environment.NewLine + "Input 2 = " + output2 + "M" + Environment.NewLine;
            }
            // in to m
            if (chkInchToMeter.Checked)
            {
                error = false;

                double output1 = (double)nudInput1.Value * 0.0254;
                double output2 = (double)nudInput2.Value * 0.0254;

                rtbOutput.Text += "Converting Inches to Meters:" + Environment.NewLine + "Input 1 = " + output1 + "m" + Environment.NewLine + "Input 2 = " + output2 + "m" + Environment.NewLine;
            }
            if (error == true)
            {
                rtbOutput.Text += "Error: Please choose convertions" + Environment.NewLine;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //The Missle knows where it is
            //Thanks for the help Roman
            rtbOutput.LoadFile("C:/Users/Sir Benjamin of hous/source/repos/weekofnov6th-BenjiKT/WeekOfNov6th/bin/test.txt", RichTextBoxStreamType.PlainText);
            rtbOutput.Text += Environment.NewLine;
        }

        private void btnMissle_Click(object sender, EventArgs e)
        {
            //Thanks for the help Roman
            rtbString.LoadFile("C:/Users/Sir Benjamin of hous/source/repos/weekofnov6th-BenjiKT/WeekOfNov6th/bin/test.txt", RichTextBoxStreamType.PlainText);
            string text = rtbString.Text;
            string[] missle = text.Split(' ');

            if(nudInput1.Value == 0)
            {
                rtbOutput.Text += "The string knows it's length:" + missle.Length + Environment.NewLine;
            }
            else
            {
                int check = 1;
                for(int i = 1; i < missle.Length+1; i++)
                {
                    
                    if (check == nudInput1.Value)
                    {
                        rtbOutput.Text += missle[i] + ", ";
                        check = 0;
                    }
                    check++;
                }
                rtbOutput.Text += Environment.NewLine;
            }

        }
    }
}
