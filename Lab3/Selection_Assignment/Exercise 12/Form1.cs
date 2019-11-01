using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            const int BASICPRICE = 12;
            int age;
            int price;

            age = int.Parse(txtAge.Text);
            price = BASICPRICE;

            if (age < 5)
            {
                price = 0;
            }
            else if (age >= 5 && age <= 12)
            {
                price = BASICPRICE / 2;
            }
            else if (age >= 13 && age <= 54)
            {
                price = BASICPRICE;
            }
            else if (age >= 55)
            {
                price = 0;
            }
            
            

            lblPrice.Text = "€ " + price.ToString("0.00");
        }
    }
}
