using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                Console.Write(list[i]);
                Console.Write(" ");

            }

            Console.WriteLine();
            Console.WriteLine();


            do
            {
                Console.WriteLine("Enter a number you want to add the list");
                num = int.Parse(Console.ReadLine());
                list.Add(num);


                for (int i = 0; i < list.Count; i++)
                    {
                        Console.Write(list[i]);
                    }
                    Console.WriteLine();
                


            } while (num != 2);



            Console.ReadKey();
        }
    }
}
