using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix2
{
    internal class Program
    {
        public static char[,] matrix;
        public static int playerRow;
        public static int playerCol;
        public static Stack<char> text;

        private static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            text = new Stack<char>(input);
            int size = int.Parse(Console.ReadLine());
            matrix = new char[size, size];
            playerRow = 0;
            playerCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            string command = Console.ReadLine();

            while (command != "end")
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
                command = Console.ReadLine();
            }
            Console.WriteLine($"{string.Join("", text.Reverse())}");
            PrintMatrix();
        }

        public static bool IsValidCordinate(int row, int col)
        {
            return IsValidROw(row) && IsValidCol(col);
        }

        public static bool IsValidROw(int row)
        {
            return row >= 0 && row < matrix.GetLength(0);
        }

        public static bool IsValidCol(int col)
        {
            return col >= 0 && col < matrix.GetLength(1);
        }

        public static void MovePlayer(int newRow, int newCol)
        {
            if (IsValidCordinate(newRow, newCol))
            {
                if (matrix[newRow, newCol] == '-')
                {
                    matrix[newRow, newCol] = 'P';
                    matrix[playerRow, playerCol] = '-';
                    playerRow = newRow;
                    playerCol = newCol;
                }
                else if (char.IsLetter(matrix[newRow, newCol]))
                {
                    text.Push(matrix[newRow, newCol]);
                    matrix[newRow, newCol] = 'P';
                    matrix[playerRow, playerCol] = '-';
                    playerRow = newRow;
                    playerCol = newCol;
                }
            }
            else
            {
                Punish();
            }
        }

        public static void Punish()
        {
            if (text.Any())
            {
                text.Pop();
            }
        }

        public static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}