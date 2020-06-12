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
            Team team = new Team();

            team.AddProgrammer(new Programmer("Peter", Speciality.Csharp));
            team.AddProgrammer(new Programmer("Kevin", Speciality.Java));
            team.AddProgrammer(new Programmer("John", Speciality.HTML));
            team.AddProgrammer(new Programmer("Susan", Speciality.PHP));
            //prints programmers with speciality
            team.PrintAllTeamMembers();

            //adds another programmer with no speciality
            team.AddProgrammer(new Programmer("Emre"));
            Console.WriteLine();
            
            //prints programmers with and without speciality again
            team.PrintAllTeamMembers();


            Console.ReadKey();
        }
    }
}
