using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
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
            CopyingMachine machine1 = CopyingMachine.GetInstance();

            Console.WriteLine("copying with machine 1");
            machine1.Copy(10);
            machine1.Copy(23);

            Console.WriteLine();

            CopyingMachine machine2 = CopyingMachine.GetInstance();
            Console.WriteLine("copying with machine 2");
            machine2.Copy(40);

            Console.ReadKey();
        }
    }
}
