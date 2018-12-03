using System;
using System.Threading;

namespace Final_Project
{
    class Program
    {
        static int inputFight = 0;
        static int strength = 10;
        static int health = 100;
        static string name;
        static int alienStrength = 20;
        static Random rand = new Random();
        static int chanceToWin = 40;
        static string space = "    ";
        static bool isDead = false;

        static void Main(string[] args)
        {
            string[] colors = new string[] { "yellow", "blue", "red", "green", "brown"};
            int index = rand.Next(colors.Length);
            int count = 0;

            Write("What is your name?");
            Console.Write(space);
            name = Console.ReadLine();

            Write("Hello " + name + ", you are on an abondoned spaceship, and are running out of fuel quickly; you need to land.");
            int landOnPlanet;
            do
            {
                Write("You see a " +colors[index]+ " planet. Do you want to");
                Write("1. Land");
                Write("2. find another planet");
                Console.Write(space);
                landOnPlanet = int.Parse(Console.ReadLine());

                if (landOnPlanet == 2)
                {
                    if (count <= 4)
                    {
                        Write("You keep flying in hopes to find a planet, but you need to land soon.");
                    }
                    else
                    {
                        Write("You are desperately close to running out of fuel. You decide to land");
                    }

                    if (count <= 4)
                    {
                        index = rand.Next(colors.Length);
                    }
                    count++;
                }
            } while (landOnPlanet != 1 && count <= 5);
            Write("You have landed on the " +colors[index]+ " planet. You check the air, and it is not breathable, you make sure not to crack your suit.");
            Write("You leave your ship onto the forest filled planet. You see a weird plant, you examine it.");
            Write("As you examine the plant, you hear a weird noise.");
            Write("1. Keep examining the plant");
            Write("2. Examine the noise");
            Console.Write(space);
            int exPlant = int.Parse(Console.ReadLine());

            if (exPlant == 1)
            {
                health += 5;
                Write("You have gained +5 health.");
                Write("You now have " + health + " health.");
            }
            Write("You examine the sound and- You have been knocked out.");

            Write("You wake up, laying down on a table in a foreign building, you see computers to your left," +
                "\n and creatures to your right.");
            Write("1. Go to computers");
            Write("2. Go to creatures");
            Console.Write(space);
            int leaveTable = int.Parse(Console.ReadLine());

            if (leaveTable == 1)
            {
                Write("The computers seem to have some type of c# script on it, it is useless.");
            }

            Write("You go to the aliens, but the seem to be hostile, you get in a fight with one.");

            alienStrength = 20;
            Fight();
            
            Write("All I got for now");

            
            Console.ReadLine();
        }





        static void Fight()
        {
            int perCent = rand.Next(0, 100);

            do
            {
                perCent = rand.Next(0, 100);
                Write("1. Punch");
                Write("2. Flee");
                Console.Write(space);
                inputFight = int.Parse(Console.ReadLine());

                if (inputFight == 1 && perCent >= chanceToWin)
                {
                    alienStrength -= strength;
                    if (alienStrength <= 0)
                    {
                        alienStrength = 0;
                    }
                    Write("You hit the alien. it has " + alienStrength + " health left.");
                    if (alienStrength <= 0)
                    {
                        break;
                    }
                }
                else if (inputFight == 1 && perCent <= chanceToWin)
                {
                    Write("You have been hit.");
                    health -= 5;
                    if (health <= 0)
                    {
                        health = 0;
                    }
                    Write("You now have " + health + " health.");

                    if(health == 0)
                    {
                        isDead = true;
                        CharDead();
                    }
                }
            } while ((perCent <= chanceToWin && (strength - alienStrength != 0)) || inputFight != 2);
        }

        static void Write(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(45);
            }
            Thread.Sleep(200);
            Console.WriteLine();
        }

        static void CharDead()
        {
            if (isDead == true)
            {
                Write("You have died");
            }
        }
    }
}
