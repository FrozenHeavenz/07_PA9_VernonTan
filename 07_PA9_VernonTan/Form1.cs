using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_PA9_VernonTan
{
    public partial class Form1 : Form
    {
        public double UserInput;
        public double ConvertedAmt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Converted_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                UserInput = double.Parse(txt_Amount.Text);
                if (UserInput < 0)
                {
                    txt_Amount.Text = "Please enter a valid amount.";
                }
                else
                {
                    if (rb_US.Checked)
                    {
                        ConvertedAmt = (UserInput * 0.75);
                        txt_Converted.Text = ConvertedAmt.ToString();
                    }
                    else if (rb_Yen.Checked)
                    {
                        ConvertedAmt = (UserInput * 81.97);
                        txt_Converted.Text = ConvertedAmt.ToString();
                    }
                    else
                    {
                        txt_Converted.Text = "Please Select Currency!";
                    }
                }
            }
            catch (FormatException)
            {
                txt_Amount.Text = "Please enter a valid amount.";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_US_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Yen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
