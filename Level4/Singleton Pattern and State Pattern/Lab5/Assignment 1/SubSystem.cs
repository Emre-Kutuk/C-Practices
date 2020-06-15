using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class SubSystem
    {
        Logger logger = Logger.GetInstance();

        public void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "doing some more work");
        }

        public void DoSomeWork() 
        {
            logger.Log("SubSystem", "doing some work");
        }

        public SubSystem() { }

    }
}
