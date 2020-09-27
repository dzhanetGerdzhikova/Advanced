using System;
using System.Linq;

namespace Primary_Diagonal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] numsInRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numsInRow[col];
                }
            }

            int sumOfDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumOfDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sumOfDiagonal);
        }
    }
}