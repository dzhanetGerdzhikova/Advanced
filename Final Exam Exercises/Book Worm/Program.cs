using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Worm
{
    internal class Program
    {
        public static char[,] matrix;
        private static Stack<char> word;
        private static int playerRow = 0;
        private static int playerCol = 0;

        private static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            word = new Stack<char>(text);

            int n = int.Parse(Console.ReadLine());

            matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "up")
                {
                    MovePlayer(playerRow - 1, playerCol);
                }
                else if (command == "down")
                {
                    MovePlayer(playerRow + 1, playerCol);
                }
                else if (command == "left")
                {
                    MovePlayer(playerRow, playerCol - 1);
                }
                else if (command == "right")
                {
                    MovePlayer(playerRow, playerCol + 1);
                }
            }
            Console.WriteLine(string.Join("", word.Reverse()));
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void MovePlayer(int nextRow, int nextCol)
        {
            if (IsValidRow(nextRow) && IsValidCol(nextCol))
            {
                var symbol = matrix[nextRow, nextCol];
                if (char.IsLetter(symbol))
                {
                    word.Push(symbol);
                }
                matrix[nextRow, nextCol] = 'P';
                matrix[playerRow, playerCol] = '-';
                playerRow = nextRow;
                playerCol = nextCol;
            }
            else
            {
                Punish(word);
            }
        }

        private static void Punish(Stack<char> word)
        {
            if (word.Any())
            {
                word.Pop();
            }
        }

        public static bool IsValidRow(int nextRow)
        {
            if (nextRow < 0 || nextRow >= matrix.GetLength(0))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidCol(int nextCol)
        {
            if (nextCol < 0 || nextCol >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }
    }
}