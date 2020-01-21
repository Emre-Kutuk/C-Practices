using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public const string ALPHABET = "ABCDEFGHIJKLMNOPRSTUVYZQWabcdefghijklmnoprstuvyzqw !?^+%&";
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            string key = CreateSecretKey(40);
            Console.WriteLine("Secret Key : " + key);
            Console.Write("Enter the message : ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Encrypted Message : " + OneTimePad(sentence, key));
            Console.ReadKey();
        }

        string CreateSecretKey(int length)
        {
            Random rnd = new Random();
            string secretkey = "";
            for (int i = 0; i < length; i++)
            {
                int temp = rnd.Next(0, ALPHABET.Length);
                secretkey = secretkey + ALPHABET[temp];
            }
            return secretkey;
        }

        string OneTimePad(string message, string key)
        {

            string result = null;
            for (int i = 0; i < message.Length; i++)
            {
                if (!ALPHABET.Contains(message[i]))
                {
                    Console.WriteLine("Error occured while encrypting : Used alphabet does not contain character " + message[i]);
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                int msgPos = ALPHABET.IndexOf(message[i]);
                int keyPos = ALPHABET.IndexOf(key[i]);
                int totalPos = (msgPos + keyPos) % ALPHABET.Length;
                result = result + ALPHABET[totalPos];


            }

            return result;
        }
    }

}
