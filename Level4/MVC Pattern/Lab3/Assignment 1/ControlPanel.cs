using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class ControlPanel : Form
    {
        TrainJourney journey;
        TrainController controller;

        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            journey = new TrainJourney();
            controller = new TrainController(journey);
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            TrainDisplay trainDisplay = new TrainDisplay();
            journey.AddObserver(trainDisplay);
            trainDisplay.Show();
        }

        private void btnNextStation_Click(object sender, EventArgs e)
        {
            controller.NextStation();
        }
    }
}
