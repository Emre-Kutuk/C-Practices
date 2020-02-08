using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Dice
    {
        public int value;
        Random rnd = new Random();

        public Dice(Random random)
        {
            this.value = random.Next(1, 7);
        }

        public void Throw(Random random)
        {
            this.value = new Dice(random).value;
        }

        public void DisplayValue()
        {
            Console.Write(this.value + " ");
        }



    }
}
