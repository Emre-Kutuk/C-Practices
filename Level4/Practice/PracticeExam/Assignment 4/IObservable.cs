using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public interface IObservable
    {
        void AddObserver(IObserver display);
        void RemoveObserver(IObserver display);

        void NewMeasurement();

    }
}
