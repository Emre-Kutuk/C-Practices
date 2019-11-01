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

   

        private void Button2_Click(object sender, EventArgs e)
        {
            double startKM;
            double endKM;
            double priceKM;
            double vatPrice;

            startKM = double.Parse(txtStartKm.Text);
            endKM = double.Parse(txtEndKm.Text);
            priceKM = double.Parse(txtPriceKm.Text);
            vatPrice = 0.21;


            lblVat.Text = (((endKM - startKM) * priceKM) * vatPrice).ToString("0.00");
            lblPriceNoVat.Text = ((endKM - startKM) * priceKM).ToString("0.00");
            lblPriceYesVat.Text = (((endKM - startKM) * priceKM) + (((endKM - startKM) * priceKM) * vatPrice)).ToString("0.00");



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblPriceNoVat.Text = String.Empty;
            lblPriceYesVat.Text = String.Empty;
            lblVat.Text = String.Empty;
            txtEndKm.Text = String.Empty;
            txtPriceKm.Text = String.Empty;
            txtStartKm.Text = String.Empty;
        }
    }
}
