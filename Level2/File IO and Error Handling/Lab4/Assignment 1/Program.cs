using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string filename;
            Console.Write("Enter your name : ");
            filename = Console.ReadLine();
            Console.WriteLine("Welcome {0} !", filename);
            
            if(File.Exists(filename + ".txt"))
            {
                DisplayPerson(ReadPeople(filename + ".txt"));   
            }
            else
            {
                WritePerson(ReadPerson(), filename + ".txt");
            }
            Console.ReadKey();
        }

        Person ReadPerson()
        {
            Person person = new Person();

            Console.Write("Enter your name : ");
            person.name = Console.ReadLine();
            Console.Write("Enter your city : ");
            person.city = Console.ReadLine();
            Console.Write("Enter your age : ");
            person.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your data is written to file.");

            return person;
        }

        void DisplayPerson(Person p)
        {
            Console.WriteLine("Nice to see you " + p.name + 
                "\nWe have the following information about you : " +
                "\nName : " + p.name + 
                "\nCity : " + p.city + 
                "\nAge : " + p.age);
        }

        void WritePerson(Person p , string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(p.name);
            writer.WriteLine(p.city);
            writer.WriteLine(p.age);
            writer.Close();
        }
        Person ReadPeople(string filename)
        {
            Person p = new Person();
            StreamReader reader = new StreamReader(filename);
           
            p.name = reader.ReadLine();
            p.city = reader.ReadLine();
            p.age = int.Parse(reader.ReadLine());

            return p;
        }
    }
}
