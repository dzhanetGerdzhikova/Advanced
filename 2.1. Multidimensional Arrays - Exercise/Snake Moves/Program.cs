using System;
using System.Linq;

namespace Snake_Moves
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] dimensioOfMatrix = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int countRow = dimensioOfMatrix[0];
            int countRCol = dimensioOfMatrix[1];

            char[,] matrix = new char[countRow, countRCol];

            string text = Console.ReadLine();
            int counter = 0;

            for (int row = 0; row < countRow; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < countRCol; col++)
                    {
                        matrix[row, col] = text[counter];
                        counter++;
                        if (counter == text.Length)
                        {
                            counter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = countRCol - 1; col >= 0; col--)
                    {
                        matrix[row, col] = text[counter];
                        counter++;
                        if (counter == text.Length)
                        {
                            counter = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}