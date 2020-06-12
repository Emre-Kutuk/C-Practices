using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {   

        public static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();
            MainSystem mainSystem = new MainSystem();

            logger.Log("main", "starting");
            mainSystem.DoSomeMainWork();
            logger.Log("main", "finishing");

            Console.ReadKey();
        }
    }
}
