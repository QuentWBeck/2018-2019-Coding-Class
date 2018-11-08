using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];
        static char player = 'X';
        static bool win = false;
        static bool tie = false;
        static int count = -1;

        static void Main(string[] args)
        {
            Console.WindowHeight = 7;
            Console.WindowWidth = 34;

            int x = 0;
            int y = 0;

            do
            {
                count++;
                DrawBoard(board);
                PlayerTurn();

                Console.Write("Player " + player + ", enter your x place: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Player " + player + ", enter your y place: ");
                y = int.Parse(Console.ReadLine());
                
                if ((board[y, x] == 'X' || board[y, x] == 'O'))
                {
                    Console.WriteLine("You can't take that spot");
                    count--;
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                } 
                else if (board[y, x] != 'X' || board[y, x] != 'O')
                {
                    board[y, x] = player;
                }
                PlayerWin();
                Console.Clear();
            } while (win == false && tie == false);


            if (win == true)
            {
                DrawBoard(board);
                Console.WriteLine("Player " + player + " won!");
            }

            if (tie == true)
            {
                DrawBoard(board);
                Console.WriteLine("It's a tie!");
            }

            Console.ReadLine();
        }


        static void DrawBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(board[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        static void PlayerTurn()
        {
            if (count % 2 == 0)
            {
                player = 'X';
            }
            else
            {
                player = 'O';
            }
        }

        static void PlayerWin()
        {
            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player) //horizontal
                win = true;
            else if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player) //horizontal
                win = true;
            else if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player) //horizontal
                win = true;
            else if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) //diagonal
                win = true;
            else if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) //diagonal
                win = true;
            else if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player) //vertical
                win = true;
            else if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player) //vertical
                win = true;
            else if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player) //vertical
                win = true;
            else if (((board[0, 0] == 'X' || board[0, 0] == 'O') && (board[0, 1] == 'X' || board[0, 1] == 'O') 
                && (board[0, 2] == 'X' || board[0, 2] == 'O') && (board[1, 0] == 'X' || board[1, 0] == 'O') &&
                (board[1, 1] == 'X' || board[1, 1] == 'O') && (board[1, 2] == 'X' || board[1, 2] == 'O') &&
                (board[2, 0] == 'X' || board[2, 0] == 'O') && (board[2, 1] == 'X' || board[2, 1] == 'O') &&
                (board[2, 2] == 'X' || board[2, 2] == 'O')) && win == false) //Checking for a tie
                    tie = true;
        }
    }
}
