using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Set x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Set y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            PrintSquares(x, y);

            Console.ReadKey();
        }

        static void PrintSquares(int size, int size1)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size1; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

    }
}
