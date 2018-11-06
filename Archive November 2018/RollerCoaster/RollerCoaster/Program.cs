using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coaster = new int[10];
            Random rand = new Random();
            int input = 0;

            do
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("1. Add rider to random avaliable seat");
                Console.WriteLine("2. List avaliable seats");
                Console.WriteLine("3. Start ride, list amount of riders");
                Console.WriteLine("4. Exit program");
                Console.WriteLine("**************************************");

                input = int.Parse(Console.ReadLine());

                //1.Put rider in random available seat. (Ride seats 10 riders)
                if (input == 1)
                {
                    int count = 0;
                    for (int i = 0; i < coaster.Length; i++)
                    {
                        if (coaster[i] == 1)
                        {
                            count++;
                        }
                    }

                    if (count == coaster.Length)
                    {
                        Console.Write("Coaster is full");
                        Console.WriteLine();
                    }
                    else
                    {
                        do
                        {
                            int selectedChair = rand.Next(0, coaster.Length);
                            if (coaster[selectedChair] == 0)
                            {
                                coaster[selectedChair] = 1;
                                Console.Write("Person added to seat " + selectedChair);
                                Console.WriteLine();
                                break;
                            }
                        } while (true);
                    }


                }

                //2.List available seats.
                if (input == 2)
                {
                    Console.WriteLine("*****************************************");
                    Console.Write("| ");
                    for (int i = 0; i < coaster.Length; i++)
                    {
                        Console.Write(coaster[i] + " | ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("*****************************************");

                }

                //3.Start ride, print out how many people were on the ride.
                if (input == 3)
                {
                    int count = 0;
                    for (int i = 0; i < coaster.Length; i++)
                    {
                        if (coaster[i] == 1)
                        {
                            coaster[i] = 0;
                            count++;
                        }
                    }
                    if (count == 0 || count > 1)
                    {
                        Console.Write("There are " + count + " seats taken");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("There is " + count + " seat taken");
                        Console.WriteLine();
                    }
                }

            } while (input != 4);

        }
    }
}
