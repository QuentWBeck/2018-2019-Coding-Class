using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            if (age >= 16)
            {
                Console.Write("you can legally drive, but not drink");
            }
            else
            {
                if (age < 16)
                {
                    Console.Write("You can't drink or drive");
                }
                else if (age >= 21)
                {
                    Console.Write("You can drink and drive, but not at the same time!");
                }
            }
            Console.ReadKey(true);
        }
    }
}
