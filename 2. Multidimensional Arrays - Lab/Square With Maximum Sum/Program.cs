using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] matrixDatas = ReadArrayFromConsole();
            int countRow = matrixDatas[0];
            int countCol = matrixDatas[1];

            int[,] matrix = new int[countRow, countCol];

            for (int row = 0; row < countRow; row++)
            {
                int[] numsInRow = ReadArrayFromConsole();

                for (int col = 0; col < countCol; col++)
                {
                    matrix[row, col] = numsInRow[col];
                }
            }

            int sumOfSquare = 0;
            int maxSum = int.MinValue;
            int indexRow = 0;
            int indexCow = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sumOfSquare = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (sumOfSquare > maxSum)
                    {
                        maxSum = sumOfSquare;
                        indexRow = row;
                        indexCow = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[indexRow, indexCow]} {matrix[indexRow, indexCow + 1]}");
            Console.WriteLine($"{matrix[indexRow + 1, indexCow]} {matrix[indexRow + 1, indexCow + 1]}");
            Console.WriteLine(maxSum);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }
    }
}