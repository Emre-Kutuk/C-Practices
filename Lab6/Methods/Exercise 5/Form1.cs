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
        

        private void Add_Click(object sender, EventArgs e)
        {
            double nr1 = 0;
            double nr2 = 0;
            getNumbers(ref nr1, ref nr2);
            lblResult.Text = addNumbers(nr1, nr2).ToString("0.00");
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            double nr1 = 0;
            double nr2 = 0;
            getNumbers(ref nr1, ref nr2);
            lblResult.Text = substractNumbers(nr1, nr2).ToString("0.00");

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double nr1 = 0;
            double nr2 = 0;
            getNumbers(ref nr1, ref nr2);
            lblResult.Text = multiplyNumbers(nr1, nr2).ToString("0.00");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double nr1 = 0;
            double nr2 = 0;
            getNumbers(ref nr1, ref nr2);
            lblResult.Text = divideNumbers(nr1, nr2).ToString("0.00");
        }
        public double addNumbers(double nr1, double nr2)
        {
            double result = nr1 + nr2;
            return result;
        }
        public double substractNumbers(double nr1, double nr2)
        {
            double result = nr1 - nr2;
            return result;
        }
        public double multiplyNumbers(double nr1, double nr2)
        {
            double result = nr1 * nr2;
            return result;
        }
        public double divideNumbers(double nr1, double nr2)
        {
            double result = nr1 / nr2;
            return result;
        }


        private void getNumbers(ref double nr1, ref double nr2)
        {
            nr1 = double.Parse(txtNr1.Text);
            nr2 = double.Parse(txtNr2.Text);
        }
  
    }
}
