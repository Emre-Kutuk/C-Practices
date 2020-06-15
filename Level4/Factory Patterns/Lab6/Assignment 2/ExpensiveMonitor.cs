using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("displaying stuff very nice...");
        }
    }
}
