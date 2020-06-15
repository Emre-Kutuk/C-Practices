using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Team
    {
        private List<Programmer> programmers = new List<Programmer>();

        public Team() { }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer p in programmers)
                p.Print();
        }
        public void AddProgrammer(Programmer programmer)
        {
            programmers.Add(programmer);
        }

    }
}
