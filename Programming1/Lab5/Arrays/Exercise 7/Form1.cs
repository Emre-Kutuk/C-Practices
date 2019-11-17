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

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Lbl3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            const int THROW = 6000;
            int[] dice = new int[6];
            Random rnd = new Random();
            int randomNumber = 0;

            for(int i = 0; i < 6; i++)
            {
                dice[i] = 0;
            }

            for (int i = 0; i < THROW; i++)
            {
                randomNumber = rnd.Next(1, 7);
                if (randomNumber == 1)
                {
                    dice[0] += 1;
                }
                else if (randomNumber == 2)
                {
                    dice[1] += 1;
                }
                else if (randomNumber == 3)
                {
                    dice[2] += 1;
                }
                else if (randomNumber == 4)
                {
                    dice[3] += 1;
                }
                else if (randomNumber == 5)
                {
                    dice[4] += 1;
                }
                else if (randomNumber == 6)
                {
                    dice[5] += 1;
                }
            }
            lbl1.Text = dice[0].ToString();
            lbl2.Text = dice[1].ToString();
            lbl3.Text = dice[2].ToString();
            lbl4.Text = dice[3].ToString();
            lbl5.Text = dice[4].ToString();
            lbl6.Text = dice[5].ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
