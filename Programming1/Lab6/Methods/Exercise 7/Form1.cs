using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double userInput = double.Parse(txtDegree.Text);

            if (bttnCtoF.Checked)
            {
                lblResult.Text = celciusToFahrenheit(userInput).ToString("0.00");
            }
            if(bttnCtoK.Checked)
            {
                lblResult.Text = celciusToKevin(userInput).ToString("0.00");
            }
            if(bttnFtoC.Checked)
            {
                lblResult.Text = fahrenheitToCelcius(userInput).ToString("0.00");
            }


        }

        double celciusToKevin(double input)
        {
            double result = input + 273;
            return result;
        }
        double celciusToFahrenheit(double input)
        {
            double result = input * 9 / 5 + 32;
            return result;
        }
        double fahrenheitToCelcius(double input)
        {
            double result = (input - 32) * 5 / 9;
            return result;
        }



    }
}
