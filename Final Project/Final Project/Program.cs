using System;
using System.Threading;

namespace Final_Project
{
    class Program
    {
        static int inputFight = 0;
        static int strength = 10;
        static int health = 50;
        static string name;
        static int alienStrength = 20;
        static Random rand = new Random();
        static int chanceToWin = 40;
        static string space = "»";
        static bool isDead = false;
        static string weapon = "none";

        static void Main(string[] args)
        {
            //background color
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            //text color
            Console.ForegroundColor = ConsoleColor.Black;

            string[] colors = new string[] { "yellow", "blue", "red", "green", "brown"};
            int index = rand.Next(colors.Length);
            int count = 0;

            Write("What is your name?");
            Console.Write(space);
            name = Console.ReadLine();

            Stats();

            Write("Hello " + name + ", you are on an abondoned spaceship, and are running out of fuel quickly; you need to land.");
            int landOnPlanet;
            do
            {
                Write("You see a " +colors[index]+ " planet. Do you want to");
                Write("1. Land");
                Write("2. Find another planet");
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
            Write("You examine the sound and-");
            Write("You have been knocked out.");

            Write("You wake up, laying down on a table in a foreign building, you see computers to your left," +
                "\nand creatures to your right.");
            Write("1. Go to computers");
            Write("2. Go to creatures");
            Console.Write(space);
            int leaveTable = int.Parse(Console.ReadLine());

            if (leaveTable == 1)
            {
                Write("The computers seem to have some type of script on it, it is useless.");
            }

            Write("You go to the aliens, but they seem to be hostile, you get in a fight with one.");

            alienStrength = 20;
            Fight();
            
            Write("You search the building and you find a rack of weapons.");
            Write("There is a rifle, sword, and a revolver. You want the:");
            Write("1. Rifle (+5 strength)");
            Write("2. Sword (+4 strength)");
            Write("3. Revolver (+7 strength)");
            Console.Write(space);
            int chooseWepon = int.Parse(Console.ReadLine());
            

            if (chooseWepon == 1)
            {
                weapon = "rifle";
                strength += 5;
            }
            if (chooseWepon == 2)
            {
                weapon = "sword";
                strength += 4;
            }
            if (chooseWepon == 3)
            {
                weapon = "revolver";
                strength += 7;
            }


            Write("You pick up the " + weapon + " and leave the building.");
            Stats();

            Write("To the right you can head back to your spaceship, to the left, you can go to a forest.");
            Write("1. Head right");
            Write("2. Head left");
            Console.Write(space);
            int leftBuild = int.Parse(Console.ReadLine());

            if (leftBuild == 1)
            {
                Write("You head to your ship in a hurry, you don't like this planet and you want to leave.");
                Write("The main console isn't working.");
                Write("1. Smash the console");
                Write("2. Try to figure out the problem");
                Console.Write(space);
                int notWork = int.Parse(Console.ReadLine());
                if (notWork == 1)
                {
                    Write("Smashing the console worked.");
                    Write("You take off.");
                }
                if (notWork == 2)
                {
                    Write("You fix the probelm, and the ship takes off.");
                }

                Write("As you start to fly, your ship turns off and you begin to crash.");
                Write("You land in a forest.");
                Write("You leave your ship and enter the forest.");
            }
            if (leftBuild == 2)
            {
                Write("You enter the forest.");
            }

            Write("You search the forest for anything, all you can see is trees. You only have a day or two of oxygen left, " +
                "\nthe rest of the containers broke on the ship.");
            Write("You hear a noise in the distance and hide.");
            Write("Another creature comes up to you. It sees you, and you fight it");
            alienStrength = 50;
            Fight();

            Write("You start to run, because this planet is awful. You see a gun on the ground, do you want to pick it up?");
            Write("1. Take the gun");
            Write("2. Leave the gun");
            Console.Write(space);
            int pickGun = int.Parse(Console.ReadLine());
            if (pickGun == 1)
            {
                Write("You pick up the gun, it shocks you and blows up.");
                Write("-5 strength");
                strength -= 5;
                Write("-5 health");
                health -= 5;
                CharDead();
            }
            if (pickGun == 2)
            {
                Write("You walk away, and right after the gun blows up, you are unharmed.");
            }

            Stats();
            Write("You need to find a way off this planet soon, your ship is broken and the air isn't breathable.");
            Write("Night is coming soon, and you should find a place to rest.");
            Write("1. Find some sticks");
            Write("2. Keep going");
            Console.Write(space);
            int sleep = int.Parse(Console.ReadLine());
            if (sleep == 1)
            {
                Write("You found some sticks.");
                Write("1. Make a shelter");
                Write("2. Make a fire");
                Console.Write(space);
                int sticks = int.Parse(Console.ReadLine());
                if (sticks == 1)
                {
                    Write("You make a shelter and sleep. You survive the night.");
                    Write("During your rest, you heal.");
                    Write("+10 health");
                    health += 10;
                }
                if (sticks == 2)
                {
                    Write("You got very tired and forgot to put out the fire. It got out of control.");
                    isDead = true;
                    CharDead();
                }
            }
            if (sleep == 2)
            {
                Write("You keep walking throughout the night and become exhausted.");
            }

            Write("The morning comes, and with the bright light, you can see a building in the distance.");
            Write("This could be your way out.");
            Write("You check your oxygen, and you have less than a day left, you have to leave the planet.");
            Stats();

            //Final Part
            Write("You arrive at the building, and it is surrounded by aliens, but you hear ships at the back of the building.");
            Write("You see an alien, but he does not notice you.");
            Write("1. Stealth kill");
            Write("2. Sneak by");
            Console.Write(space);
            int stealth = int.Parse(Console.ReadLine());

            if (stealth == 1)
            {
                Write("You stealth kill the alien, and you take his gun.");
                Write("+5 strength");
                strength += 5;
                weapon = "alien gun";
            }
            if (stealth == 2)
            {
                Write("You sneak by the alien undetected, and there seems to be a powerful gun. You take it.");
                weapon = "alien gun";
            }

            Write("You go upstairs, and you can see the hangar in the distance.");
            Write("You just need to get there.");
            Write("1. Run for it");
            Write("2. Shoot the barrel in the distance");
            Console.Write(space);
            int goToHangar = int.Parse(Console.ReadLine());

            if (goToHangar == 1)
            {
                Write("You run for it, and every alien sees you.");
                Write("They all shoot at you, and none of them miss.");
                isDead = true;
                CharDead();
            }
            if (goToHangar == 2)
            {
                Write("You shot the barrel, and it explodes.");
                Write("Some aliens are killed, and the others are distracted.");
                Write("This is the perfect time to run.");
            }
            Write("You run to the hangar, and you see the ships, there is one open.");
            Write("As you go into the ship, there is a big alien, and he sees you.");
            alienStrength = 100;
            Write("He has " +alienStrength+ " strength.");
            FinalFight();
            
            Write("You board the ship, and the controls are foreign, but you can figure them out.");
            Write("The ship is secured, but that doesn't stop the aliens from shooting it."); 
            Write("As you get into the air, there are cannons shooting at you. One is coming directly for you.");
            Write("1. Turn left");
            Write("2. Turn right");
            Console.Write(space);
            int turn = int.Parse(Console.ReadLine());

            if (turn == 1)
            {
                Write("The shot missed, and you fly away safely.");
            }
            if (turn == 2)
            {
                Write("The shot hits you, the shit explodes.");
                isDead = true;
                CharDead();
            }
            
            Write("You get into space, and you figure out how to use communications.");
            Write("You signal for your station, and they signal back.");
            Write("Your allies get there and pull your ship to theirs. You have been saved.");
            CharWon();

            Console.ReadLine();
        }





        static void Fight()
        {
            int perCent = rand.Next(0, 100);
            
            do
            {
                perCent = rand.Next(0, 100);
                Write("1. Fight");
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
                        Write("You have won the fight!");
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
                else if (inputFight == 2)
                {
                    break;
                }
            } while ((perCent <= chanceToWin && (strength - alienStrength != 0)) || inputFight != 2);
            
            if (inputFight == 2)
            {
                Write("You flee the fight.");
            }
        }

        static void FinalFight()
        {
            int perCent = rand.Next(0, 100);
            int punchStrength = (strength - 5);
            int rounds = 5;
            chanceToWin = 30;

            do
            {
                perCent = rand.Next(0, 100);
                Write("1. Punch");
                Write("2. Shoot");
                Write("You have " +rounds+ " rounds.");
                Console.Write(space);
                inputFight = int.Parse(Console.ReadLine());

                if (inputFight == 1 && perCent >= chanceToWin)
                {
                    alienStrength -= punchStrength;
                    if (alienStrength <= 0)
                    {
                        alienStrength = 0;
                    }
                    Write("You punch the alien. it has " + alienStrength + " health left.");
                    if (alienStrength <= 0)
                    {
                        Write("You have won the fight!");
                        break;
                    }
                }
                else if (inputFight == 1 && perCent <= chanceToWin)
                {
                    Write("You have been hit.");
                    health -= 7;
                    if (health <= 0)
                    {
                        health = 0;
                    }
                    Write("You now have " + health + " health.");

                    if (health == 0)
                    {
                        isDead = true;
                        CharDead();
                    }
                }
                else if (inputFight == 2 && perCent >= chanceToWin)
                {
                    if (rounds == 0)
                    {
                        Write("You don't have any bullets left");
                        continue;
                    }
                    alienStrength -= strength;
                    if (alienStrength <= 0)
                    {
                        alienStrength = 0;
                    }
                    Write("You shoot the alien. it has " + alienStrength + " health left.");
                    if (alienStrength <= 0)
                    {
                        Write("You have won the fight!");
                        break;
                    }
                    rounds--;
                }
                else if (inputFight == 2 && perCent <= chanceToWin)
                {
                    Write("You missed.");
                    if (rounds == 0)
                    {
                        Write("You don't have any bullets left");
                        continue;
                    }
                    Write("You have been hit.");
                    health -= 7;
                    if (health <= 0)
                    {
                        health = 0;
                    }
                    Write("You now have " + health + " health.");

                    if (health == 0)
                    {
                        isDead = true;
                        CharDead();
                    }
                    rounds--;
                }

            } while (strength != 0 || alienStrength != 0);
            
        }

        static void Write(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(45);
            }
            Thread.Sleep(500);
            Console.WriteLine();
        }

        static void CharDead()
        {
            if (isDead == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Write("You have died.");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }

        static void Stats()
        {
            Write("Your stats:");
            Write("Health: " + health);
            Write("Strength: " + strength);
            Write("Weapon: " + weapon);
        }

        static void CharWon()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Write("You have won!");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}
