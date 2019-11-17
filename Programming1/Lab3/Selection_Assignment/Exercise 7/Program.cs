using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float kg;
            float cm;
            string gender;
            string bmi;
            string healthymin;
            string healthymax;


            Console.Write("Enter Weight (kg) : ");
            kg = float.Parse(Console.ReadLine());
            Console.Write("Enter Height (cm) : ");
            cm = float.Parse(Console.ReadLine());
            Console.Write("Enter Gender (male/female) : ");
            gender = Console.ReadLine();
          


            bmi = (kg / ((cm / 100) * (cm / 100))).ToString("0.0");

            Console.WriteLine("bmi-value : " + bmi);
            if(gender == "male")
            {
                Console.WriteLine("normal bmi-values (min .. max) : 20..25 ");
                healthymin = (20 * ((cm / 100) * (cm / 100))).ToString("0.0");
                healthymax = (25 * ((cm / 100) * (cm / 100))).ToString("0.0");
                Console.WriteLine("Healthy Weight Range : " + healthymin + ".." + healthymax);
            }
            else if(gender == "female")
            {
                Console.WriteLine("normal bmi-values (min .. max) : 19..24 ");
                healthymin = (19 * ((cm / 100) * (cm / 100))).ToString("0.0");
                healthymax = (24 * ((cm / 100) * (cm / 100))).ToString("0.0");
                Console.WriteLine("Healthy Weight Range : " + healthymin + ".." + healthymax);
            }
            else
            {
                Console.WriteLine("INCORRECT GENDER");
            }




            Console.ReadKey();
        }

    }
}
