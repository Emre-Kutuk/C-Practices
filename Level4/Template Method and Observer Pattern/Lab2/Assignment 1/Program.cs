using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            BatchProcessor batchProcessor = new BatchProcessor();

            batchProcessor.AddBigDataLoader(new CallDataLoader());
            batchProcessor.AddBigDataLoader(new TwitterDataLoader());
            batchProcessor.AddBigDataLoader(new SensorDataLoader());

            batchProcessor.PrintAll();
            Console.ReadKey();
        }
    }
}
