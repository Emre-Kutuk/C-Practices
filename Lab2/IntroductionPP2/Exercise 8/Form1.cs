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
            timer.Enabled = true;
            timer.Interval = 1000;

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            const double TSHIRTPRICE = 30;
            const double JEANSPRICE = 100;
            double vat;
            double tshirts;
            double jeans;

            vat = 0.21;
            tshirts = double.Parse(txtTshirts.Text);
            jeans = double.Parse(txtJeans.Text);

            lblPrice.Text = ((tshirts * TSHIRTPRICE) + (jeans * JEANSPRICE)).ToString("0.00");
            lblVat.Text = (((tshirts * TSHIRTPRICE) + (jeans * JEANSPRICE)) * vat).ToString("0.00");
            lblTotal.Text = ((((tshirts * TSHIRTPRICE) + (jeans * JEANSPRICE)) * vat) + ((tshirts * TSHIRTPRICE) + (jeans * JEANSPRICE))).ToString("0.00");


        }
    }
}
