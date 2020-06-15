using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class TrainJourney : ITrainJourney
    {
        private List<ITrainDisplay> observers = new List<ITrainDisplay>();
        private List<TrainStation> stations = new List<TrainStation>();

        TrainStation currentStation;
        int currentStationNo;
        bool direction;

        public TrainJourney()
        {
            stations.Add(new TrainStation("Delft", "1", new DateTime(2020,05,06,07,09,00), new DateTime(2020, 05, 06, 07, 09, 00)));
            stations.Add(new TrainStation("Den Haag HS", "6", new DateTime(2020, 05, 06, 07, 16, 00), new DateTime(2020, 05, 06, 07, 18, 00)));
            stations.Add(new TrainStation("Den Haag Laan v NOI", "6", new DateTime(2020, 05, 06, 07, 21, 00), new DateTime(2020, 05, 06, 07, 21, 00)));
            stations.Add(new TrainStation("Leiden Centraal", "5b", new DateTime(2020, 05, 06, 07, 30, 00), new DateTime(2020, 05, 06, 07, 31, 00)));
            stations.Add(new TrainStation("Schiphol Airport", "1-2", new DateTime(2020, 05, 06, 07, 46, 00), new DateTime(2020, 05, 06, 07, 46, 00)));

            currentStationNo = 0;
            direction = true;
            currentStation = stations[currentStationNo];
            
        }


        public void AddObserver(ITrainDisplay observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(ITrainDisplay observer)
        {
            observers.Remove(observer);
        }

        public void NextStation()
        {
            currentStation = stations[currentStationNo];

            if (currentStationNo == stations.Count - 1)
                direction = false;
            else if (currentStationNo == 0)
                direction = true;

            if (direction)
                currentStationNo++;
            else
                currentStationNo--;

            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (ITrainDisplay o in observers)
            {
                o.Update(currentStation);
            }
        }
    }
}
