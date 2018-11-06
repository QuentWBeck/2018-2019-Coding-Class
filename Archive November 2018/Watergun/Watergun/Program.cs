using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watergun
{
    class Program
    {
        static void Main(string[] args)
        {
            float input2;
            bool play1Win, play2Win;
            Watergun gun = new Watergun();
            Watergun2 gun2 = new Watergun2();
            do
            {
                Console.WriteLine("Player 1, do you want to shoot or refill");
                string input = Console.ReadLine();

                if (input == "shoot")
                {
                    Console.WriteLine("How much do you want to shoot");
                    float input1 = float.Parse(Console.ReadLine());
                    gun.Shoot(input1);

                    if (gun.Shoot(input1) == true)
                    {
                        play1Win = true;
                    }
                    else
                    {
                        play1Win = false;
                    }
                    
                }
                if (input == "refill") 
                {
                    gun.Refill();
                }

               /* Console.WriteLine("Player 2, do you want to shoot or refill");
                string input3 = Console.ReadLine();
                if (input == "shoot")
                {
                    Console.WriteLine("How much do you want to shoot");
                    input2 = float.Parse(Console.ReadLine());
                    gun2.Shoot(input2);

                    if (gun.Shoot(input2) == true)
                    {
                        play2Win = true;
                    }
                    else
                    {
                        play2Win = false;
                    }
                } 
                if (input == "refill")
                {
                    gun2.Refill();
                }*/
                Console.ReadKey();
                Console.Clear();
            } while (true);
            Console.ReadLine();
        }

    }

    
}
