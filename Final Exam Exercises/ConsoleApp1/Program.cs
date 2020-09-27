using System;
using System.Data;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int countPresents;
        public static char[,] matrix;
        public static int santaRow;
        public static int santaCol;
        public static int niceKidsCounter;
        public static int presentForNiceKids;

        private static void Main(string[] args)
        {
            countPresents = int.Parse(Console.ReadLine());
            int sizeofMatrix = int.Parse(Console.ReadLine());
            matrix = new char[sizeofMatrix, sizeofMatrix];
            niceKidsCounter = 0;
            presentForNiceKids = 0;

            for (int row = 0; row < sizeofMatrix; row++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int col = 0; col < sizeofMatrix; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                    if (matrix[row, col] == 'V')
                    {
                        niceKidsCounter++;
                    }
                }
            }

            string command;
            while (countPresents > 0 && (command = Console.ReadLine()) != "Christmas morning")
            {
                if (command == "up")
                {
                    MoveSanta(santaRow - 1, santaCol);
                }
                else if (command == "down")
                {
                    MoveSanta(santaRow + 1, santaCol);
                }
                else if (command == "left")
                {
                    MoveSanta(santaRow, santaCol - 1);
                }
                else if (command == "right")
                {
                    MoveSanta(santaRow, santaCol + 1);
                }
            }
            if (countPresents <= 0)
            {
                Console.WriteLine($"Santa ran out of presents!");
            }
            PrintMatrix();
            if (presentForNiceKids >= niceKidsCounter)
            {
                Console.WriteLine($"Good job, Santa! {niceKidsCounter} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidsCounter - presentForNiceKids} nice kid/s.");
            }
        }

        public static void MoveSanta(int newRow, int newCol)
        {
            if (matrix[newRow, newCol] == 'X' || matrix[newRow, newCol] == '-')
            {
                matrix[santaRow, santaCol] = '-';
                matrix[newRow, newCol] = 'S';
                santaRow = newRow;
                santaCol = newCol;
            }
            else if (matrix[newRow, newCol] == 'V')
            {
                matrix[santaRow, santaCol] = '-';
                matrix[newRow, newCol] = 'S';
                santaRow = newRow;
                santaCol = newCol;

                countPresents--;
                presentForNiceKids++;
            }
            else if (matrix[newRow, newCol] == 'C')
            {
                matrix[santaRow, santaCol] = '-';
                matrix[newRow, newCol] = 'S';
                santaRow = newRow;
                santaCol = newCol;

                GivePresentEveryone(santaRow + 1, santaCol);
                GivePresentEveryone(santaRow - 1, santaCol);
                GivePresentEveryone(santaRow, santaCol + 1);
                GivePresentEveryone(santaRow, santaCol - 1);
            }
        }

        public static void GivePresentEveryone(int newRow, int newCol)
        {
            if (matrix[newRow, newCol] == 'V')
            {
                countPresents--;
                presentForNiceKids++;
            }
            else if (matrix[newRow, newCol] == 'X')
            {
                countPresents--;
            }
            matrix[newRow, newCol] = '-';
        }

        public static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}