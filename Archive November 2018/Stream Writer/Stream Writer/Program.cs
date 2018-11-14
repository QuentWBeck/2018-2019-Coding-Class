using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Stream_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("Enter 1 to save a random array to a file");
                Console.WriteLine("Enter 2 to load a random array from a file");
                Console.WriteLine("Enter 3 to exit");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    int[] arr = new int[10];
                    Random rand = new Random();

                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = rand.Next(0, 10);
                    }

                    string path;
                    path = @"C:\Users\quent\Desktop\Programs\New Folder\Archive November 2018\IO Direction\Example.txt";
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";

                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            sw.Write(arr[i]);
                        }
                    }

                    Console.WriteLine("Saved");
                    Thread.Sleep(500);
                }

                if (input == 2)
                {
                    int[] arr = new int[10];
                    Random rand = new Random();

                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = rand.Next(0, 10);
                    }

                    string path;
                    path = @"C:\Users\quent\Desktop\Programs\New Folder\Archive November 2018\IO Direction\Example.txt";
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";

                    List<string> file = new List<string>();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.Write(line);
                        }
                    }
                    Console.ReadLine();
                } Console.Clear();
            } while (input != 3);

        }
    }
}
