using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Programmer
    {
        private string name;
        private Speciality speciality;

       public void Print()
        {
            Console.WriteLine("Name : {0} , Speciality : {1}", name, speciality);
        }

        public Programmer(string name, Speciality speciality)
        {
            this.name = name;
            this.speciality = speciality;
        }

        public Programmer(string name) : this(name, Speciality.Unknown) { }

    }
}
