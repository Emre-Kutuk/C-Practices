using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        Person[] people = new Person[3];
        static void Main(string[] args)
        {
            Program myprogram = new Program();

            myprogram.Start();
        }
        void Start()
        {
            AskFor3();
            CelebrateBirthday(ref people[1]);
            PrintPerson(people[1]);
            Console.ReadKey();
        }
        Person ReadPerson()
        {
            Person person;

            
            person.FirstName = ReadString("Enter First Name : ");
            person.LastName = ReadString("Enter Last Name : ");
            person.Gender = ReadGender("Enter gender (m/f) : ");
            person.Age = ReadInt("Enter Age : ");
            person.City = ReadString("Enter City : ");
            Console.WriteLine();

            int ReadInt(string question)
            {
                Console.Write(question);
                int value = int.Parse(Console.ReadLine());
                return value;

            }
            string ReadString(string question)
            {
                Console.Write(question);
                string value = Console.ReadLine();
                return value;

            }
            GenderType ReadGender(string question)
            {
                GenderType gender;
                string value = ReadString(question);

                while (value != "m" && value != "f")
                {
                    Console.Write(question);
                    value = Console.ReadLine();
                }
                if (value == "m")
                    gender = GenderType.Male;
                else
                    gender = GenderType.Female;
                
                return gender;
            }
            return person;
        }
        void PrintPerson(Person p)
        {
            Console.Write("{0} {1}", p.FirstName, p.LastName);
            PrintGender(p.Gender);
            Console.WriteLine("{0} years old, {1}", p.Age, p.City);
            Console.WriteLine();
        }

        void PrintGender(GenderType gender)
        {
            string gen = "";

            if (gender == GenderType.Male)
                gen = "m";
            else if (gender == GenderType.Female)
                gen = "f";

            Console.Write("({0}) ", gen);
                    
        }



        void AskFor3()
        {

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = ReadPerson();
            }
            for (int i = 0; i < people.Length; i++)
            {
                PrintPerson(people[i]);
            }
        }

        void CelebrateBirthday(ref Person person)
        {
            person.Age++;
            
        }


    }
}
