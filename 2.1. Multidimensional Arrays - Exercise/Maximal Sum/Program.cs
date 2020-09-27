using System;
using System.Linq;

namespace Maximal_Sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] matrixDatas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int countRow = matrixDatas[0];
            int countCol = matrixDatas[1];

            int[,] matrix = new int[countRow, countCol];

            MatrixInitial(matrix);
            int sumOfSquare = 0;
            int maxSum = int.MinValue;
            int rowForMaxSquare = 0;
            int colForMaxSquare = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sumOfSquare = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sumOfSquare > maxSum)
                    {
                        maxSum = sumOfSquare;
                        rowForMaxSquare = row;
                        colForMaxSquare = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = rowForMaxSquare; row <= rowForMaxSquare + 2; row++)
            {
                for (int col = colForMaxSquare; col <= colForMaxSquare + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static void MatrixInitial(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numsInRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numsInRow[col];
                }
            }
        }
    }
}