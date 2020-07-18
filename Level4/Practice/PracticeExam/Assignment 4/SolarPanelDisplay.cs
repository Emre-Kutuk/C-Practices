using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class SolarPanelDisplay : IObserver
    {
        private IObservable system;

        public SolarPanelDisplay(IObservable system)
        {
            this.system = system;
            system.AddObserver(this);
        }

        public void Update(int value)
        {
            Console.WriteLine($"New measurement: {value} watt");
        }
    }
}
