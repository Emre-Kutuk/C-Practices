using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            const double SECONDPR = 53;
            const double FIRSTP = 87.46;
            const double RAILRUNNERPR = 2.50;

            if (bttn2nd.Checked)
            {
                lblPrice.Text = ("€ " + ((double.Parse(txtTickets.Text) * SECONDPR) + (double.Parse(txtRail.Text) * RAILRUNNERPR)).ToString("0.00"));
            }

            if (bttn1st.Checked)
            {
                lblPrice.Text = ("€ " + ((double.Parse(txtTickets.Text) * FIRSTP) + (double.Parse(txtRail.Text) * RAILRUNNERPR)).ToString("0.00"));
            }
        }

        private void Bttn2nd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
