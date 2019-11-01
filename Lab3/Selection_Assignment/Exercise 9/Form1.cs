using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int feePrice;
            int age = int.Parse(txtAge.Text);
            int duration = int.Parse(txtDur.Text);



            if (BttnFootball.Checked)
                {
                feePrice = 175;
                }
            else if(BttnHandball.Checked)
                {
                feePrice = 225;
                }
            else
                {
                feePrice = 0;
                }

            if(age > 40)
            {
                feePrice -= 25;
            }

            if(duration > 10)
            {
                feePrice -= 20;
            }

            lblPrice.Text = "€ " + (feePrice.ToString("00.00"));

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtDur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
