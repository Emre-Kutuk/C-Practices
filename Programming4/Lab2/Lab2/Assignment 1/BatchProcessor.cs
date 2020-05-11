using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BatchProcessor
    {
        List<BigDataLoader> bigDataLoaders = new List<BigDataLoader>();

        public void AddBigDataLoader(BigDataLoader bigDataLoader)
        {
            bigDataLoaders.Add(bigDataLoader);
        }

        public void PrintAll()
        {
            foreach(BigDataLoader b in bigDataLoaders)
            {
                b.ETL();
            }
        }
    }
}
