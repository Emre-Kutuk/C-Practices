using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
                
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void VATBtn_Click(object sender, EventArgs e)
        {
            string inputPrice = txtPrice.Text;
            double price = double.Parse(inputPrice);

            double VATPercent = 0.21;
            double VAT = price * VATPercent;
            double totalPrice = price + VAT;

            lblPrice.Text = price.ToString("0.00");
            lblVAT.Text = VAT.ToString("0.00");
            lblTotal.Text = totalPrice.ToString("0.00");
        }
    }
}
