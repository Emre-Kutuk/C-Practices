using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double days;
            double kms;
            double tankedFuel;
            double price;

            price = 0;
            days = double.Parse(txtRentDays.Text);
            kms = double.Parse(txtKm.Text);
            tankedFuel = double.Parse(txtLiter.Text);

            if(chckRefuel.Checked && (kms <= (100 * days)))
            {
                price = (55 * days) + (tankedFuel * 2.20);
            }
            if (chckRefuel.Checked && (kms > (100 * days)))
            {
                price = (55 * days) + (tankedFuel * 2.20) + ((kms - (100 * days)) * 0.25);
            }
            if (!chckRefuel.Checked && (kms <= (100 * days)))
            {
                price = (55 * days);
            }
            if (!chckRefuel.Checked && (kms > (100 * days)))
            {
                price = (55 * days) + ((kms - (100* days)) * 0.25);
            }

                lblPrice.Text = "€ " + price.ToString("0.00");
        }
    }
}
