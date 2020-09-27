using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    internal class Program
    {
        private static char[,] matrix;
        private static int startPlayerRow;
        private static int startPlayerCol;

        private static void Main(string[] args)
        {
            int[] datasMatrix = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int countRows = datasMatrix[0];
            int countCols = datasMatrix[1];

            matrix = new char[countRows, countCols];
            FillMatrix();

            char[] commands = Console.ReadLine().ToCharArray();

            foreach (var currentCommand in commands)
            {
                int currentPlayerRow = startPlayerRow;
                int currentPlayerCol = startPlayerCol;
                bool hasWon = false;

                switch (currentCommand)
                {
                    case 'L': // col-1
                        if (IsValidCol(startPlayerCol - 1))
                        {
                            currentPlayerCol = startPlayerCol - 1;
                        }
                        else
                        {
                            matrix[currentPlayerRow, currentPlayerCol] = '.';
                            hasWon = true;
                        }
                        break;

                    case 'R': // col+1
                        if (IsValidCol(startPlayerCol + 1))
                        {
                            currentPlayerCol = startPlayerCol + 1;
                        }
                        else
                        {
                            matrix[currentPlayerRow, currentPlayerCol] = '.';
                            hasWon = true;
                        }
                        break;

                    case 'U': // row+1
                        if (IsValidRow(startPlayerRow - 1))
                        {
                            currentPlayerRow = startPlayerRow - 1;
                        }
                        else
                        {
                            matrix[currentPlayerRow, currentPlayerCol] = '.';
                            hasWon = true;
                        }
                        break;

                    case 'D': // row-1
                        if (IsValidRow(startPlayerRow + 1))
                        {
                            currentPlayerRow = startPlayerRow + 1;
                        }
                        else
                        {
                            matrix[currentPlayerRow, currentPlayerCol] = '.';
                            hasWon = true;
                        }
                        break;

                    default:
                        break;
                }

                if (matrix[currentPlayerRow, currentPlayerCol] == '.')
                {
                    matrix[currentPlayerRow, currentPlayerCol] = 'P';
                    matrix[startPlayerRow, startPlayerCol] = '.';
                    startPlayerRow = currentPlayerRow;
                    startPlayerCol = currentPlayerCol;
                }

                List<BunnyPosition> bunnies = FindCurrentBunnies();
                foreach (var currentBunny in bunnies)
                {
                    SpreadBunny(currentBunny);
                }
                if (hasWon)
                {
                    PrintMatrix();
                    Console.WriteLine($"won: {currentPlayerRow} {currentPlayerCol}");
                    return;
                }
                bool isAlive = IsOurManAlive();

                if (!isAlive)
                {
                    PrintMatrix();
                    Console.WriteLine($"dead: {currentPlayerRow} {currentPlayerCol}");
                    return;
                }
            }
        }

        private static bool IsOurManAlive()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void SpreadBunny(BunnyPosition currentBunny)
        {
            // Up
            if (IsValidRow(currentBunny.Row - 1))
            {
                matrix[currentBunny.Row - 1, currentBunny.Col] = 'B';
            }

            //Down
            if (IsValidRow(currentBunny.Row + 1))
            {
                matrix[currentBunny.Row + 1, currentBunny.Col] = 'B';
            }

            //Right
            if (IsValidCol(currentBunny.Col + 1))
            {
                matrix[currentBunny.Row, currentBunny.Col + 1] = 'B';
            }

            //Left
            if (IsValidCol(currentBunny.Col - 1))
            {
                matrix[currentBunny.Row, currentBunny.Col - 1] = 'B';
            }
        }

        private static void FillMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] dataInRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = dataInRow[col];

                    if (matrix[row, col] == 'P')
                    {
                        startPlayerRow = row;
                        startPlayerCol = col;
                    }
                }
            }
        }

        private static bool IsValidRow(int row)
        {
            return row >= 0 && row < matrix.GetLength(0);
        }

        private static bool IsValidCol(int col)
        {
            return col >= 0 && col < matrix.GetLength(1);
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        private static List<BunnyPosition> FindCurrentBunnies()
        {
            List<BunnyPosition> bunnies = new List<BunnyPosition>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunnies.Add(new BunnyPosition(row, col));
                    }
                }
            }
            return bunnies;
        }
    }
}

internal class BunnyPosition
{
    public BunnyPosition(int row, int col)
    {
        Row = row;
        Col = col;
    }

    public int Row { get; set; }
    public int Col { get; set; }
}