using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_10
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
            double salary;
            double total;
            double raise;

            salary = double.Parse(txtSalary.Text);
            raise = salary * 0.05;

            if (raise<=75)
            {
                raise = 75;
            }

            total = salary + raise;

            lblRaise.Text = "€ " + raise.ToString("0.00");
            lblSalary.Text = "€ " + total.ToString("0.00");

        }
    }
}
