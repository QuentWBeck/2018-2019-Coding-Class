using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGame
{
    class Character
    {
        static void Attrubuites(string name, string hairColor, 
            int height, int weight, string shirtShize)
        {
            Console.Write("Enter you name: ");
            name = Console.ReadLine();
            Console.Write("Enter your hair color: ");
            hairColor = Console.ReadLine();
            Console.Write("Enter you height in inches: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter you weight: ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Enter your shirt size: ");
            shirtShize = Console.ReadLine();                                                                                                            
        }
    }
}
