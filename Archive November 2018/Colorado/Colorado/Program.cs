using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colorado
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string result;

            Console.Write("Do you live in Colorado? ");
            result = Console.ReadLine();

            if (result.ToLower()[0] == 'n')
            {
                Console.Write("You don't live in Colorado you can't smoke marijuana");
            }
            Console.ReadKey(true);

            if (result.ToLower()[0] == 'y')
            {
                Console.Write("What is your age? ");
                age = int.Parse(Console.ReadLine());
                if (result.ToLower()[0] == 'y' && age >= 21)
                {
                    Console.Write("You live in Colorado, and can consume marijuana");
                }
                else
                {
                    Console.Write("You live in Colorado but cannot consume marijuana");
                }
                Console.ReadKey(true);
            }
        }
    }
}
