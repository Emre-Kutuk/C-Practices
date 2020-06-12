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
            ComputerShop expensiveShop = new HighBudgetShop();
            Console.WriteLine("[shop creating expensive computers]");
            expensiveShop.Assemble();

            Console.WriteLine();

            ComputerShop cheapshop = new LowBudgetShop();
            Console.WriteLine("[shop creating cheap computers]");
            cheapshop.Assemble();
            Console.ReadKey();
        }
    }
}
