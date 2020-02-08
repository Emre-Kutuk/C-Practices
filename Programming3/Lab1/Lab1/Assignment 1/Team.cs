using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Team
    {
        List<Programmer> programmers = new List<Programmer>();

        public Team()
        {
            Programmer p1 = new Programmer("Peter", Speciality.Csharp);
            Programmer p2 = new Programmer("Kevin", Speciality.Java);
            Programmer p3 = new Programmer("John", Speciality.HTML);
            Programmer p4 = new Programmer("Susan", Speciality.PHP);
            programmers.Add(p1);
            programmers.Add(p2);
            programmers.Add(p3);
            programmers.Add(p4);
        }

        public void PrintAllTeamMembers()
        {
            for (int i = 0; i < programmers.Count; i++)
                programmers[i].Print();
        }
        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }

    }
}
