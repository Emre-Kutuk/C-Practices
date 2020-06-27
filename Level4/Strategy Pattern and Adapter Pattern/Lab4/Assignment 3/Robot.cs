using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Robot
    {
        private Random generator;

        public Robot()
        {
            generator = new Random();
        }


        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with his hands.");
        }

        public void MoveByPerson()
        {
            Console.WriteLine("Robot is moved by Mark");
        }

        public void WalkForward()
        {
            Console.WriteLine("Robot moves " + generator.Next(1, 10) + " steps forward.");
        }
    }
}
