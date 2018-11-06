using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName;

            Console.Write("What is your first name? ");
            fName = Console.ReadLine();
            Console.Write("What is your last name? ");
            lName = Console.ReadLine();
            Console.Write("Hello, " + fName + " " + lName + ", you're awesome!");

            Console.ReadKey(true);
        }
    }
}
