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

        int[] numbers = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label[] firstLabels = new Label[20] {label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20};

            Random rnd = new Random();
            for (int i=0; i < firstLabels.Length ; i++)
            {
                
                numbers[i] = rnd.Next(0, 501);
                firstLabels[i].Text = "Element " + i + " = " + numbers[i]; 

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int comparisonNo;

            comparisonNo = int.Parse(txtCompare.Text);

            Label[] secondLabels = new Label[20] { label_21, label_22, label_23, label_24, label_25, label_26, label_27, label_28, label_29, label_30, label_31, label_32, label_33, label_34, label_35, label_36, label_37, label_38, label_39, label_40 };
            
            for(int i = 0; i < secondLabels.Length; i++)
            {
                if(numbers[i] >= comparisonNo)
                {
                    numbers[i] += 10;
                    secondLabels[i].Text = "Element " + i + " = " + numbers[i];
                }
                else
                {
                    numbers[i] -= 5;
                    secondLabels[i].Text = "Element " + i + " = " + numbers[i];
                }
            }
            button1.Enabled = false;
            
            
            }
    }
}
