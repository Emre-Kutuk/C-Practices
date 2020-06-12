using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class MainSystem
    {
        private Logger logger = Logger.GetInstance();
        private SubSystem subSystem = new SubSystem();

        public void DoSomeMainWork() 
        {
            logger.Log("MainSystem", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }

        public MainSystem() 
        {
        }

    }
}
