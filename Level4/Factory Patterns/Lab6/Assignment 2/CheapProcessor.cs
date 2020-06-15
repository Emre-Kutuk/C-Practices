using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("performing operation not so quickly...");
        }
    }
}
