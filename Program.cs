using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your guess:");
            Random ran = new Random();
            int r = ran.Next(100);          
            int n = int.Parse(Console.ReadLine());
            int turns = 0;
            while (n!=r)
            {
                if (n>r)
                {
                    Console.WriteLine("v");
                    n = int.Parse(Console.ReadLine());
                }
                else if (n<r)
                {
                    Console.WriteLine("^");
                    n = int.Parse(Console.ReadLine());
                }
                turns++;
            }           
            Console.WriteLine($"Winner in {turns} turns!");
        }
    }
    }

