using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int inputNumber;
            int summary1st = 0;
            int summary2nd = 0;

            inputNumber = int.Parse(txtNumber.Text);

            for (int i = 1; i <= inputNumber; i++)
            {
                summary1st += i; 
            }

            summary2nd = inputNumber * (inputNumber + 1) / 2;

            lblSum1.Text = summary1st.ToString();
            lblSum2.Text = summary2nd.ToString();

            if(summary1st == summary2nd)
            {
                lblResult.Text = "The sum and formula are equal.";
            }
            else
            {
                lblResult.Text = "The sum and formula are NOT equal.";
            }
            
        }
    }
}
