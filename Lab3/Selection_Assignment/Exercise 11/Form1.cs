using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_11
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double number1;
            double number2;
            double avg;
        

            number1 = double.Parse(txtNr1.Text);
            number2 = double.Parse(txtNr2.Text);

            avg = (number1 + number2) / 2;
            lblAvg.Text = avg.ToString();

            if(number1 >= number2)
            {
                lblHighest.Text = number1.ToString();
                lblDif.Text = (number1 - avg).ToString();
            }
            else
            {
                lblHighest.Text = number2.ToString();
                lblDif.Text = (number2 - avg).ToString();
            }


        }
    }
}
