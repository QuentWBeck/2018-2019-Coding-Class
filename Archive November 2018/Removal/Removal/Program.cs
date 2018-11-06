using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                Console.Write(i);
            }
            Console.WriteLine();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                list.RemoveAt(i);
                Console.Write(i);
            }
            Console.WriteLine();



            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = 0;
                Console.Write(arr[i]);
            }
            

            Console.ReadKey();
        }
    }
}
