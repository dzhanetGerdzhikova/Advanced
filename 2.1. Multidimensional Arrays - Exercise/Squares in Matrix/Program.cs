using System;
using System.Linq;

namespace Squares_in_Matrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int countRow = matrixDimensions[0];
            int countCol = matrixDimensions[1];

            char[,] matrix = new char[countRow, countCol];
            MatrixInitialize(matrix);
            int countEqualSqu = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        countEqualSqu++;
                    }
                }
            }
            Console.WriteLine(countEqualSqu);
        }

        private static void MatrixInitialize(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] charsInRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = charsInRow[col];
                }
            }
        }
    }
}