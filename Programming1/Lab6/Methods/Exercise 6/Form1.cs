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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnReference_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            SquareByReference(ref number);
            lblResult.Text = number.ToString();
            
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            int square;
            int number = int.Parse(txtNumber.Text);
            SquareByReferenceOut(number, out square);
            lblResult.Text = square.ToString();
        }

        private void BtnValue_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            lblResult.Text = SquareByValue(number).ToString();

        }

        void SquareByReference(ref int number)
        {
            number = number * number;
        }
            
        void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }
        
        int SquareByValue(int number)
        {
            int result = number * number;
            return result;

        }


    }
}
