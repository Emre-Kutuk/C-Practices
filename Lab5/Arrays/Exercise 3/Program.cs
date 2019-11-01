using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string coursename;
            int students;
            string[] names;
            double[] grades;
            double total = 0;
            double grade;
            double highestGrade = 0;
            int highestGradeSt = 0;

            Console.Write("Enter course name : ");
            coursename = Console.ReadLine();

            Console.Write("Enter number of students : ");
            students = int.Parse(Console.ReadLine());

            names = new string[students];
            grades = new double[students];

            Console.WriteLine("\n");

            for (int i = 0; i < students; i++)
            {
                Console.Write("Enter the name of student " + (i + 1) + " : ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\n");

            for (int j = 0; j < students; j++)
            {
                Console.Write("Enter the grade of " + names[j] + " : ");
                grade = double.Parse(Console.ReadLine());
                grades[j] = grade;
                total += grade;
                if(highestGrade < grade)
                {
                    highestGrade = grade;
                    highestGradeSt = j;
                }
            }

            Console.WriteLine("\n");

            Console.WriteLine("Average grade " + (total/students).ToString("0.00"));
            Console.WriteLine("Student " + names[highestGradeSt] + " has maximum grade " + highestGrade);
            Console.WriteLine("\n");

            for (int o=0; o < students; o++)
            {
                Console.WriteLine("Grade for student " + names[o] + " (course " + coursename + ") is : " + grades[o]);
            }


            Console.ReadKey();

        }
    }
}
