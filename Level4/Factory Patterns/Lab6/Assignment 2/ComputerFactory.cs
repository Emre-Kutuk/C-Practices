﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public abstract class ComputerFactory

    {
        public abstract IHardDisk CreateHardDisk();
        public abstract IProcessor CreateProcessor();
        public abstract IMonitor CreateMonitor();
    }
}
