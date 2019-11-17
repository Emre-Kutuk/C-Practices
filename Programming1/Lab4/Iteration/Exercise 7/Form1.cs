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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int sides;
            string squareLabel = "";

            sides = int.Parse(txtSide.Text);

            for(int i = 1 ; i <= sides; i++)
            {
                if (i == 1 || i == sides )
                {
                    for(int o = 1; o <= sides; o++)
                    {
                        squareLabel += "X";
                    }
                    squareLabel += "\n";
                }
                else
                {
                    squareLabel += "X";

                    for (int o = 1; o <= sides - 2; o++)
                    {
                        squareLabel += " ";
                    }
                   
                    squareLabel += "X\n";
                }

            }
                    lblSquare.Text = squareLabel;

        }




    }
}

