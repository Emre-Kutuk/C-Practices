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
            DisplayReport(ReadReport(3));
            Console.ReadKey();
        }

        public bool Passed(int grade, PracticalGrade practicalgrade)
        {
            if (grade >= 55 && (int)practicalgrade > 2)
                return true;
            else
                return false;
        }

        public bool CumLaude(int grade, PracticalGrade practicalgrade)
        {
            if (grade >= 80 && (int)practicalgrade == 4)
                return true;
            else
                return false;
        }
        List<Course> ReadReport(int nrOfCourses)
        {
            List<Course> report = new List<Course>();

            for (int i = 1; i <= nrOfCourses; i++)
            {
                report.Add(ReadCourse("Enter a course"));
                Console.WriteLine();
            }

            return report;
        }

        void DisplayReport(List<Course> report)
        {
            int retakes = 0;
            int cumlaude = 0;
            for(int i = 0; i < report.Count; i++)
            {
                string output = "";
                output += string.Format("{0 ,-15}", report[i].name);
                output += string.Format("{0 , -10}", report[i].grade.ToString());
                output += string.Format("{0 , -5}", report[i].practical);

                if (!Passed(report[i].grade, report[i].practical))
                    retakes++;
                if (CumLaude(report[i].grade, report[i].practical))
                    cumlaude++;

                Console.WriteLine(output);
            }
            Console.WriteLine();
            if (retakes > 0)
                Console.WriteLine("Too bad, you did not graduate, you got {0} retake(s).", retakes);
            else if (cumlaude == report.Count)
                Console.WriteLine("You passed with Cum Laude!");
            else
                Console.WriteLine("Yay. You passed!");

        }
        Course ReadCourse(string question)
        {
            Course course = new Course();
            Console.WriteLine(question);
            course.name = ReadString("Name of the course : ");
            course.grade = ReadInt("Grade for " + course.name + " : ");
            ShowAvailablePractical();
            course.practical = ReadPracticalGrade("Practical grade for " + course.name + " : ");

            return course;
        }

        int ReadInt(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            int value = int.Parse(Console.ReadLine());
            Console.ResetColor();
            return value;

        }

        string ReadString(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            string value = Console.ReadLine();
            Console.ResetColor();
            return value;
        }

        PracticalGrade ReadPracticalGrade(string question)
        {
            PracticalGrade practicalgrade;
            int value = ReadInt(question);
            Console.ForegroundColor = ConsoleColor.Green;
            practicalgrade = (PracticalGrade)value;
            Console.ResetColor();
            return practicalgrade;
        }

        void ShowAvailablePractical()
        {
            for(int i = 0; i < Enum.GetNames(typeof(PracticalGrade)).Length; i++)
            {
                Console.Write(i + ". " + (PracticalGrade)i + " ");
            }
            Console.WriteLine();
        }
    }
}
