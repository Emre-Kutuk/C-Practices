using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class CallDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting call data...");
        }
        public override void Transform()
        {
            Console.WriteLine("transforming call data...");
        }

        public override void Load()
        {
            Console.WriteLine("loading call data...");
        }
    }
}
