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
            Team t = new Team();
            t.PrintAllTeamMembers();
            
            /*Programmer programmer = new Programmer("Emre");
            t.AddProgrammer(programmer);
            Console.WriteLine();
            t.PrintAllTeamMembers();*/


            Console.ReadKey();
        }
    }
}
