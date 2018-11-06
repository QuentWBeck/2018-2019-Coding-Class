using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty, rev = string.Empty;
            Console.WriteLine("Enter a word and see if there's a palindrome");
            str = Console.ReadLine();
            str = str.ToLower().Replace(" ", "").Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace(":", "").Replace(";", "");

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
                if (rev == str)
                {
                    Console.Write("Palindrome");
                }
                else
                {
                    Console.Write("No palindrome");
                }

            Console.ReadKey();
        }
    }
}
