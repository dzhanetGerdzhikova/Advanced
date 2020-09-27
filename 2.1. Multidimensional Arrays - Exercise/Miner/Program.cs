using System;
using System.Linq;

namespace Miner
{
    internal class Program
    {
        private static char[,] matrix;
        private static int minerRow;
        private static int minerCol;
        private static int countCoal;

        private static void Main(string[] args)
        {
            int datasMatrix = int.Parse(Console.ReadLine());

            matrix = new char[datasMatrix, datasMatrix];

            string[] directions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            FillMatrix();

            foreach (var cuurDirection in directions)
            {
                switch (cuurDirection)
                {
                    case "right":
                        if (IsValidCol(minerCol + 1))
                        {
                            minerCol++;
                        }
                        break;

                    case "left":
                        if (IsValidCol(minerCol - 1))
                        {
                            minerCol--;
                        }
                        break;

                    case "up":
                        if (IsValidRow(minerRow - 1))
                        {
                            minerRow--;
                        }
                        break;

                    case "down":
                        if (IsValidRow(minerRow + 1))
                        {
                            minerRow++;
                        }
                        break;

                    default:
                        break;
                }
                if (matrix[minerRow, minerCol] == 'c')
                {
                    countCoal--;
                    matrix[minerRow, minerCol] = '*';
                    if (countCoal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }
                }
                else if (matrix[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
            }
            Console.WriteLine($"{countCoal} coals left. ({minerRow}, {minerCol})");
        }

        private static void FillMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    if (matrix[row, col] == 'c')
                    {
                        countCoal++;
                    }
                }
            }
        }

        private static bool IsValidCol(int col)
        {
            return col >= 0 && col < matrix.GetLength(1);
        }

        private static bool IsValidRow(int row)
        {
            return row >= 0 && row < matrix.GetLength(0);
        }
    }
}