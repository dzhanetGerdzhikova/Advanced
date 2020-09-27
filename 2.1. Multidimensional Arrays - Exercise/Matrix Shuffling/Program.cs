using System;
using System.Linq;

namespace Matrix_Shuffling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int countRow = dimension[0];
            int countCol = dimension[1];

            string[,] matrix = new string[countRow, countCol];
            MatrixInitional(matrix);

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string command = input[0];

            while (command != "END")
            {
                if (command == "swap")
                {
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);

                    int rowMaxIndex = matrix.GetLength(0);
                    int colMaxIndex = matrix.GetLength(1);

                    if (input.Length == 5 && IsValidInput(row1, rowMaxIndex) && IsValidInput(row2, rowMaxIndex) && IsValidInput(col1, colMaxIndex) && IsValidInput(col2, colMaxIndex))
                    {
                        string firstNum = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = firstNum;

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                command = input[0];
            }
        }

        private static void MatrixInitional(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numsInRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numsInRow[col];
                }
            }
        }

        private static bool IsValidInput(int colOrRowIndex, int maxIndex) =>
             colOrRowIndex >= 0 && colOrRowIndex < maxIndex;

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}