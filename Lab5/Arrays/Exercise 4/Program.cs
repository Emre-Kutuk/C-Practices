using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = new int[20];
            int userInput = 1;
            int times = 0;
            int searchValue = 0;

            for (int i = 0; ;)
            {
                
                if (userInput != 0 && i < 20 )
                {
                    Console.Write("Enter a number (0 = stop) : ");
                    userInput = int.Parse(Console.ReadLine());
                    inputNumbers[i] = userInput;
                    i++;
                }

                else
                {
                    Console.Write("\n" + "Enter a search value : ");
                    searchValue = int.Parse(Console.ReadLine());
                    
                    for(int j = 0; j < i;)
                    {
                        if(searchValue == inputNumbers[j])
                        {
                            times++;
                        }
                        j++;
                    }

                    Console.WriteLine("\n" + "Number of occurences of search value(" + searchValue + ")" + " is : " + times);
                    Console.ReadKey();

                }
            }
            
                
            }
            

        }
    }

