using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_6
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

        private void Button1_Click(object sender, EventArgs e)
        {
            double moneyInput;
            int i;


            moneyInput = double.Parse(txtMoney.Text);

            for (i = 0; i <5;)
            {

                i++;
                moneyInput = moneyInput * 1.05;

            }

            lblFinalCapital.Text = "€ " + moneyInput.ToString("0.00");



        }
    }
}
