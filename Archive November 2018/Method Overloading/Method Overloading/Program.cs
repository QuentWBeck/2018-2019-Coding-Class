using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[,] twoDArray = new int[3, 3];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    twoDArray[i, j] = rand.Next(0, 10);
                }
            }

            Print(5);
            Console.WriteLine();
            Print(array);
            Console.WriteLine();
            Print(twoDArray);

            Console.ReadLine();
        }

        static void Print(int a)
        {
            Console.WriteLine("Integer " + a);
        }
        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|" + array[i] + "");
            }
            Console.WriteLine("|");
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(array[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        static void Print(int[][] array)
        {

        }
    }
}
