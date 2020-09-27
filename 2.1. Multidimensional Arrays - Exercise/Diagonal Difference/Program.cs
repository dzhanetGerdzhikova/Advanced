using System;
using System.Linq;

namespace Diagonal_Difference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int matrixDatas = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixDatas, matrixDatas];

            for (int row = 0; row < matrixDatas; row++)
            {
                int[] numsInRow = ReadArrayFromConsole();

                for (int col = 0; col < matrixDatas; col++)
                {
                    matrix[row, col] = numsInRow[col];
                }
            }
            int sumDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumDiagonal += matrix[row, col];
                    }
                }
            }
            int otherDiagonal = 0;
            int indexLastColum = matrix.GetLength(1) - 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = indexLastColum; col >= 0; col--)
                {
                    if (col == indexLastColum - row)
                    {
                        otherDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"{Math.Abs(sumDiagonal - otherDiagonal)}");
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}