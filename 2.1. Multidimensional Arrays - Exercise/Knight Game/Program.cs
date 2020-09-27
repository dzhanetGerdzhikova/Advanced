using System;

namespace Knight_Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int arrayDimmension = int.Parse(Console.ReadLine());

            char[][] matrix = new char[arrayDimmension][];

            FillChessMatrix(matrix);
            int killerRow = 0;
            int killerColumn = 0;
            int knightsToRemove = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        int currentAttack = 0;

                        if (matrix[row][col] == 'K')
                        {
                            if (IsValidRowOrCol(matrix, row - 1, col + 2) && matrix[row - 1][col + 2] == 'K')
                            {
                                currentAttack++;
                            }

                            if (IsValidRowOrCol(matrix, row - 1, col - 2) && matrix[row - 1][col - 2] == 'K')
                            {
                                currentAttack++;
                            }

                            if (IsValidRowOrCol(matrix, row + 2, col + 1) && matrix[row + 2][col + 1] == 'K')
                            {
                                currentAttack++;
                            }

                            if (IsValidRowOrCol(matrix, row + 2, col - 1) && matrix[row + 2][col - 1] == 'K')
                            {
                                currentAttack++;
                            }

                            if (IsValidRowOrCol(matrix, row + 1, col + 2) && matrix[row + 1][col + 2] == 'K')
                            {
                                currentAttack++;
                            }

                            if (IsValidRowOrCol(matrix, row + 1, col - 2) && matrix[row + 1][col - 2] == 'K')
                            {
                                currentAttack++;
                            }

                            if (IsValidRowOrCol(matrix, row - 2, col - 1) && matrix[row - 2][col - 1] == 'K')
                            {
                                currentAttack++;
                            }

                            if (IsValidRowOrCol(matrix, row - 2, col + 1) && matrix[row - 2][col + 1] == 'K')
                            {
                                currentAttack++;
                            }

                            if (currentAttack > maxAttacks)
                            {
                                maxAttacks = currentAttack;
                                killerRow = row;
                                killerColumn = col;
                            }
                        }
                    }
                }
                if (maxAttacks > 0)
                {
                    knightsToRemove++;
                    matrix[killerRow][killerColumn] = 'O';
                }
                else
                {
                    Console.WriteLine(knightsToRemove);
                    break;
                }
            }
        }

        private static bool IsValidRowOrCol(char[][] matrix, int rowIndex, int colIndex)
        {
            if (rowIndex >= 0 && rowIndex < matrix.GetLength(0) && colIndex >= 0 && colIndex < matrix.GetLength(0))
            {
                return true;
            }
            return false;
        }

        private static void FillChessMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }
        }
    }
}