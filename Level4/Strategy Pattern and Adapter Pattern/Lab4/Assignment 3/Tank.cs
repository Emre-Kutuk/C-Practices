using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Tank : IAttacker
    {
        private Random generator;

        public Tank()
        {
            generator = new Random();
        }

        public void AssignDriver()
        {
            Console.WriteLine("Frank is steering the tank.");
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves " + generator.Next(1, 10) + " positions forward.");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage.");
        }
    }
}
