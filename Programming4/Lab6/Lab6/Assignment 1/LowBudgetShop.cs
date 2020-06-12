using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class LowBudgetShop : ComputerShop
    {
        public override IHardDisk CreateHardDisk()
        {
            return new CheapHardDisk();
        }

        public override IMonitor CreateMonitor()
        {
            return new CheapMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }
    }
}
