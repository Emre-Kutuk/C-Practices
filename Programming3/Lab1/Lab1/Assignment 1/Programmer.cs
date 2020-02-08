using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Programmer
    {
        string name;
        Speciality speciality;

       public void Print()
        {
            Console.WriteLine("Name : {0} , Speciality : {1}", name, speciality);
        }

        public Programmer(string n, Speciality s)
        {
            name = n;
            speciality = s;
        }
        
        public Programmer(string n) : this (n , Speciality.Unknown)
        {
        }

    }
}
