using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qbeck_HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            //the list of words the program chooses
            string[] mainWords = new string[20];
            mainWords[0] = "minor";
            mainWords[1] = "kick";
            mainWords[2] = "cloistered";
            mainWords[3] = "punishment";
            mainWords[4] = "small";
            mainWords[5] = "glistening";
            mainWords[6] = "shivering";
            mainWords[7] = "stretch";
            mainWords[8] = "baby";
            mainWords[9] = "seashore";
            mainWords[10] = "receptive";
            mainWords[11] = "obsequious";
            mainWords[12] = "truck";
            mainWords[13] = "dog";
            mainWords[14] = "auspicious";
            mainWords[15] = "depressed";
            mainWords[16] = "bomb";
            mainWords[17] = "offer";
            mainWords[18] = "fetch";
            mainWords[19] = "toad";

            string input1;
            do
            {
                Console.WriteLine("Do you want to play Hangman? Enter yes or no");
                input1 = Console.ReadLine().ToLower();

                if (input1 == "yes")
                {
                    //come up with random
                    Random rand = new Random();
                    //make word
                    int randNum = rand.Next(0, 20);
                    string chooseWord = mainWords[randNum];
                    //input
                    List<char> guesses = new List<char>();
                    int lives = 6;
                    bool won = false;

                    Console.WriteLine("Welcome to Hangman! Guess a letter to begin.");
                    for (int i = 0; i < chooseWord.Length; i++)
                    {
                        Console.Write(chooseWord.Replace(chooseWord, "_"));
                    }
                    Console.WriteLine();

                    do
                    {
                        char input = char.Parse(Console.ReadLine());
                        guesses.Add(input);
                        won = true;

                        for (int i = 0; i < chooseWord.Length; i++)
                        {
                            if (guesses.Contains(chooseWord[i]))
                            {
                                Console.Write(chooseWord[i]);
                            }

                            else
                            {
                                Console.Write("_");
                                won = false;
                            }

                        }
                        Console.WriteLine();
                        Console.Write("You have guessed: ");
                        guesses.ForEach(Console.Write);
                        Console.WriteLine();

                        if (!chooseWord.Contains(input))
                        {
                            if (lives == 1)
                                Console.WriteLine("You have " + lives + " try left");
                            if (lives != 1)
                                Console.WriteLine("You have " + lives + " tries left");
                            Console.WriteLine();

                            lives--;
                            if (lives < 0)
                                Console.WriteLine("You lost.");
                        }


                    } while (won != true && lives >= 0);

                    if (won == true)
                        Console.WriteLine("You won!");
                    else
                        Console.WriteLine("The word was: " + chooseWord);


                    Console.ReadKey();
                }
            } while (input1 != "no");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
