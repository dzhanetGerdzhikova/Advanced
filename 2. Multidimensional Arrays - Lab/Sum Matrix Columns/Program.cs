using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] matrixDatas = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int countRow = matrixDatas[0];
            int countCol = matrixDatas[1];

            int[,] matrix = new int[countRow, countCol];

            for (int row = 0; row < countRow; row++)
            {
                int[] numsInRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < countCol; col++)
                {
                    matrix[row, col] = numsInRow[col];
                }
            }
            int sumNumInCol = 0;
            for (int col = 0; col < countCol; col++)
            {
                for (int row = 0; row < countRow; row++)
                {
                    sumNumInCol += matrix[row, col];
                }
                Console.WriteLine(sumNumInCol);
                sumNumInCol = 0;
            }
        }
    }
}