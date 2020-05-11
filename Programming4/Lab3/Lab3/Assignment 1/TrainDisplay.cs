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
    public partial class TrainDisplay : Form, ITrainDisplay
    {

        public TrainDisplay()
        {
            InitializeComponent();
        }

        public void Update(TrainStation station)
        {
            lblCurrentSt.Text = station.Name;
            lblRailwayTrk.Text = station.ArrivalTrack;
            lblArrival.Text = station.ArrivalTime.ToString();
            lblDeparture.Text = station.DepartureTime.ToString();
        }

        private void TrainDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
