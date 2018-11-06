using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter a base: ");
            int radix = int.Parse(Console.ReadLine());
            Binary(N, radix);

            Console.ReadLine();
        }

        static void NumToChar()
        {
            for (int i = 0; i < 13000; i++)
            {
                int myInt = i;
                char myChar = (char)myInt;
                Console.Write(myChar);
            }

            Console.ReadKey();
        }

        static void CharToInt()
        {
            char[] alpha = new char[26];
            alpha[0] = 'a';
            alpha[1] = 'b';
            alpha[2] = 'c';
            alpha[3] = 'd';
            alpha[4] = 'e';
            alpha[5] = 'f';
            alpha[6] = 'g';
            alpha[7] = 'h';
            alpha[8] = 'i';
            alpha[9] = 'j';
            alpha[10] = 'k';
            alpha[11] = 'l';
            alpha[12] = 'm';
            alpha[13] = 'n';
            alpha[14] = 'o';
            alpha[15] = 'p';
            alpha[16] = 'q';
            alpha[17] = 'r';
            alpha[18] = 's';
            alpha[19] = 't';
            alpha[20] = 'u';
            alpha[21] = 'v';
            alpha[22] = 'w';
            alpha[23] = 'x';
            alpha[24] = 'y';
            alpha[25] = 'z';



            for (int i = 0; i < alpha.Length; i++)
            {
                int myInt = alpha[i];
                Console.WriteLine(alpha[i]+ " = " +myInt);
            }
            Console.ReadKey();
        }

        static void Encryption()
        {
            Console.Write("Enter a string to decrypt: ");
            string dec = Console.ReadLine();
            Console.Write("How many spaces to you want to move it: ");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < dec.Length; i++)
            {
                //put to a num
                int myInt = dec[i];
                //add i
                
                myInt += num;
                
                if (myInt >= 123)
                    myInt -= 26;

                if (myInt <= 96)
                    myInt += 26;

              

                char back = (char)myInt;

                Console.Write(back);
            }
            Console.ReadKey();
            Console.WriteLine();

            for (int i = 0; i <= 26; i++)
            {
                for (int k = 0; k < dec.Length; k++)
                {
                    int myInt2 = dec[k];

                    myInt2 += i;

                    if (myInt2 >= 123)
                        myInt2 -= 26;

                    if (myInt2 <= 96)
                        myInt2 += 26;


                    char back2 = (char)myInt2;
                    Console.Write(back2);
                }
                Console.WriteLine();

            } Console.ReadKey();
        }

        static void Binary(int N, int radix)
        {
            if (radix < 2 || radix > 36)
            {
                Console.Write("Not valid base");
                return;
            } 
            if (N < 0)
            {
                N = Math.Abs(N);
                Console.Write('-');
            }
            int remainder = N % radix;
            int quotient = N / radix;
            
            if (quotient != 0)
            {
                Binary(quotient, radix);
            }
            char c = (char)('0' + remainder);
            Console.Write(c);

        }

    }
}
