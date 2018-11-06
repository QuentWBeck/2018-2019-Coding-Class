using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("Press 1 to print a 1x1 square");
                Console.WriteLine("Press 2 to pring a 3x3 square");
                Console.WriteLine("Press 3 to print a 5x4 rectangle");
                Console.WriteLine("Press 4 to print a right triangle going right");
                Console.WriteLine("Press 5 to print a right triangle going left");
                Console.WriteLine("Press 6 to print a really weird object that i don't know how to describe");
                Console.WriteLine("Press 7 to print another really weird object that i don't know how to describe");
                Console.WriteLine("Press 8 to print a third really weird object that i don't know how to describe");
                Console.WriteLine("Press 9 to print a pyramid");
                Console.WriteLine("Press 10 to exit");
                Console.WriteLine("*************************************************");

                num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine("X");
                    Console.WriteLine();
                }

                else if (num == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();

                    }
                    Console.WriteLine();
                }

                else if (num == 3)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                else if (num == 4)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j <5; j++)
                        {
                            if (j == i || j < i)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                else if (num == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j == i || 4 - j < i)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                else if (num == 6)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j > i || j < i)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                else if (num == 7)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j > i || 4 - j < i)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                else if (num == 8)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i || 4 - j == i)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                else if (num == 9 )
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == 2 || i >= 2 || (i >= 1 && j != 0 && j != 4))
                            Console.Write("X");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            } while (num != 10);
            Console.WriteLine("Press exit to enter");
         
            Console.ReadKey();
        }
    }
}
