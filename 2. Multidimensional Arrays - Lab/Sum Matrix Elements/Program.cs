using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] matrixDatas = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int countRow = matrixDatas[0];
            int countCol = matrixDatas[1];

            Console.WriteLine(countRow);
            Console.WriteLine(countCol);

            int[,] matrix = new int[countRow, countCol];

            int sumNum = 0;

            for (int row = 0; row < countRow; row++)
            {
                int[] numbersInRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < countCol; col++)
                {
                    matrix[row, col] = numbersInRow[col];
                }
            }
            foreach (var item in matrix)
            {
                sumNum += item;
            }
            Console.WriteLine(sumNum);
        }
    }
}