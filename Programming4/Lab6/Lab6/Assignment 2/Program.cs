using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
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
            ComputerShop expensiveShop = new ComputerShop();
            Console.WriteLine("[shop creating expensive computers]");
            expensiveShop.Assemble(new HighBudgetFactory());
            
            Console.WriteLine();

            ComputerShop cheapShop = new ComputerShop();
            Console.WriteLine("[shop creating cheap computers]");
            cheapShop.Assemble(new LowBudgetFactory());
            Console.ReadKey();
        }
    }
}
