using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class SolarPanelSystem : IObservable
    {
        private Random random = new Random();
        private List<IObserver> observers = new List<IObserver>();
        public int Power { get; private set; }

        public void AddObserver(IObserver display)
        {
            observers.Add(display);
        }

        public void NewMeasurement()
        {
            Power = random.Next(300, 500);
            NotifyObservers();
        }

        public void RemoveObserver(IObserver display)
        {
            observers.Remove(display);
        }

        private void NotifyObservers()
        {
            foreach (IObserver display in observers)
                display.Update(Power);
        }
    }
}
