using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qbeck_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess, tries=0;
            int[] arr = new int[1000];
            Random rand = new Random();

            int num = rand.Next(0, arr.Length);
            Console.WriteLine("I have a number");

            do
            {
                Console.WriteLine("Guess my number, 1-" +arr.Length);
                guess = int.Parse(Console.ReadLine());
                for (int i = 0; i <= arr.Length; i++)
                {

                    if (guess > num)
                    {
                        Console.Write("Guess lower");
                        Console.WriteLine();
                        break;
                    }
                    if (guess < num)
                    {
                        Console.Write("Guess higher");
                        Console.WriteLine();
                        break;
                    }
                }
                tries++;
            } while (guess != num);
            Console.WriteLine("You got it! The number is " + num);          
            Console.Write("It took you " + tries + " tries");
            Console.ReadKey();

        }
    }
}