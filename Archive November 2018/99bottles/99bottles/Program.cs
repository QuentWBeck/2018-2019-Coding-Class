using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //starts at 99 and goes to 0
            for (i = 99; i > 0; i--)
            {
                Console.WriteLine(i+ " bottles of beer on the wall " +i+ " bottles of beer. Take one down, pass it around " + (i-1) + " bottles of beer on the wall! ");
                Console.WriteLine(" ");
                //makes it gramatically correct once at one bottle
                if (i < 2)
                {
                    Console.WriteLine(i+ " bottle of beer on the wall " + i + " bottle of beer. Take one down, pass it around " + (i - 1) + " bottles of beer on the wall!");
                }
            }
            Console.ReadKey(true);
        }
    }
}
