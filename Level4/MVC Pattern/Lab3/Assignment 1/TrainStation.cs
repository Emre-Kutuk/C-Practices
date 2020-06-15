using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class TrainStation
    {
        public string Name;
        public string ArrivalTrack;
        public DateTime ArrivalTime;
        public DateTime DepartureTime;

        public TrainStation(string name, string arrivalTrack, DateTime arrivalTime, DateTime departureTime)
        {
            Name = name;
            ArrivalTrack = arrivalTrack;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }

        
    }
}
