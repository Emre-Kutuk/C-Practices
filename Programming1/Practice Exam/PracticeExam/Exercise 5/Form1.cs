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
            const double km5 = 5;
            const double km10 = 10;
            const double km21 = 21;
            double distance = 0;
            double timeInSecs = 0;

            if (bttn5km.Checked)
                distance = km5;
            if (bttn10km.Checked)
                distance = km10;
            if (bttn21km.Checked)
                distance = km21;

            timeInSecs = double.Parse(txtSc.Text) + double.Parse(txtMn.Text) * 60 + double.Parse(txtHr.Text) * 3600;
            lblSpeed.Text = calculateSpeed(timeInSecs, distance).ToString("0.000");


        }

        static double calculateSpeed(double timeInSecs, double distance)
        {
            double speed = 0;
            speed = (distance / timeInSecs) * 3600;


            return speed;
        }



    }
}
