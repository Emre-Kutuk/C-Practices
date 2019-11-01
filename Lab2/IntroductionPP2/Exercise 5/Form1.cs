using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int no1;
            int no2;
            int no3;

            no1 = int.Parse(txtNr1.Text);
            no2 = int.Parse(txtNr2.Text);
            no3 = int.Parse(txtNr3.Text);

            int average = (no1 + no2 + no3) / 3;

            lblAvg.Text = average.ToString("0.00");


        }
    }
}
