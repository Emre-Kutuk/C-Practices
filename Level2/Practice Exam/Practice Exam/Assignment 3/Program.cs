using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            CompareParties(ProcessPremises(ReadPremises("premises.txt.txt")), ReadParties("parties.txt.txt"));
            Console.ReadKey();
        }

        List<Premise> ReadPremises(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<Premise> premises = new List<Premise>();
            if (File.Exists(filename))
            {
                while (!reader.EndOfStream)
                {
                    Premise temp = new Premise();
                    temp.title = reader.ReadLine();
                    temp.text = reader.ReadLine();
                    premises.Add(temp);
                }
            }
            else
                Environment.Exit(0);

            reader.Close();
            return premises;
        }

        List<Party> ReadParties(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<Party> parties = new List<Party>();

            if (File.Exists(filename))
            {
                while (!reader.EndOfStream)
                {
                    Party temp = new Party();
                    temp.name = reader.ReadLine();
                    temp.answers = reader.ReadLine();
                    parties.Add(temp);
                }
            }
            else
                Environment.Exit(0);

            reader.Close();
            return parties;
        }

        string ProcessPremises(List<Premise> premises)
        {
            string userAnswers = null;

            for (int i = 0; i < premises.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(i+1 +". "+ premises[i].title);
                Console.ResetColor();
                Console.WriteLine(premises[i].text);
                Console.Write("Enter your opinion (1 = agree / 2 = disagree / 3 = no opinion) : ");
                userAnswers += Console.ReadLine();
            }

            return userAnswers;
        }

        double DetermineMatch(string user, Party party)
        {
            int count = 0;

            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == party.answers[i])
                    count++;
            }

            double result = (count / (double)user.Length) * 100;
            return result;
        }

        void CompareParties(string user, List<Party> parties)
        {
            for(int i = 0; i < parties.Count; i++)
            {
                Console.WriteLine(parties[i].name +"  : %" +DetermineMatch(user, parties[i]));
            }
        }
    }
}
