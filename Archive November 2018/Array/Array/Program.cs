using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(rand.Next());
            }
            Console.ReadKey();
        }
    }
}
