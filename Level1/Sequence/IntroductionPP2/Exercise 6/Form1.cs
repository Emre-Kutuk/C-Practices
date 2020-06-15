using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_6
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int inputInt;
            int hour;
            int minute;
            int second;
            string hourStr;
            string minuteStr;
            string secondStr;


            inputInt = int.Parse(txtSeconds.Text);
            hour = inputInt / 3600;
            minute = (inputInt - (hour * 3600)) / 60;
            second = inputInt - ((hour * 3600) + (minute * 60));

            hourStr = hour.ToString("00");
            minuteStr = minute.ToString("00");
            secondStr = second.ToString("00");

            lblResult.Text = hourStr + ":" + minuteStr + ":" + secondStr;
            



        }
    }
}
