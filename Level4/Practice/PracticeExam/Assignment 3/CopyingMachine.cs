using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class CopyingMachine
    {
        private int totalNumberOfCopies = 0;
        private static CopyingMachine uniqueInstance;


        public int TotalNumberOfCopies {
            get { return totalNumberOfCopies; }
            set { totalNumberOfCopies = value; } }

        private CopyingMachine() { }
        public static CopyingMachine GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new CopyingMachine();

            return uniqueInstance;
        }



        public void Copy(int nrOfCopies)
        {
            TotalNumberOfCopies += nrOfCopies;
            Console.WriteLine($"copying, {nrOfCopies}x \ntotal number of copies ; {TotalNumberOfCopies}x");
        }
    }
}
