using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public interface ITrainJourney
    {
        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
        void NextStation();

    }
}
