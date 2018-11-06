using System;

namespace WhatDoYouWant
{
    class Program
    {
        static void Main(string[] args)
        {
            int result, age;
            string name, live;
            do
            {
                Console.WriteLine("***************************************************");
                Console.WriteLine("Enter the number for the action you want to preform");
                Console.WriteLine("1. Enter your name");
                Console.WriteLine("2. Are you able to drink and drive?");
                Console.WriteLine("3. Can you smoke weed?");
                Console.WriteLine("4. Exit the program");
                Console.WriteLine("***************************************************");

                result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    Console.WriteLine("Enter your fist and last name");
                    name = Console.ReadLine();
                    Console.WriteLine("Hello, " + name);
                }
                else if (result == 2)
                {
                    Console.WriteLine("What is your age? ");
                    age = int.Parse(Console.ReadLine());

                    if (age < 16)

                        Console.WriteLine("You cannot drink or drive");
                    else
                    {
                        if (age <= 21)
                            Console.WriteLine("You can drive, but not drink");
                        else if (age >= 21)
                            Console.WriteLine("You can drink and drive, just not at the same time");
                    }
                }
                else if (result == 3)
                {
                    Console.WriteLine("Where do you live? ");
                    live = Console.ReadLine();
                    if (live.ToLower() != "colorado")
                        Console.WriteLine("You cannot smoke marijuana");
                    else
                    {
                        Console.WriteLine("What is your age? ");
                        int age2 = int.Parse(Console.ReadLine());
                        if (live.ToLower() == "colorado" && age2 >= 21)
                            Console.WriteLine("You can smoke weed");
                        else if (live.ToLower() == "colorado" && age2 <21)
                            Console.WriteLine("You cannot smoke weed");
                    }
                }
            } while (result != 4);
            Console.WriteLine("Press any key to exit");




            
        }
    }
}
