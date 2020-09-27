using System;

namespace Tron_Racers
{
    internal class Program
    {
        private static char[,] matrix;
        private static int rowFPlayer = 0;
        private static int colFPlayer = 0;
        private static int rowSPlayer = 0;
        private static int colSPlayer = 0;

        private static void Main(string[] args)
        {
            int countRowCol = int.Parse(Console.ReadLine());
            matrix = new char[countRowCol, countRowCol];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'f')
                    {
                        rowFPlayer = row;
                        colFPlayer = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        rowSPlayer = row;
                        colSPlayer = col;
                    }
                }
            }

            while (true)
            {
                string[] commandsInput = Console.ReadLine().Split();
                string firstPlayerCommand = commandsInput[0];
                string secondPlayerCommand = commandsInput[1];

                if (firstPlayerCommand == "up")
                {
                    MoveFPlayer(rowFPlayer - 1, colFPlayer);
                }
                else if (firstPlayerCommand == "down")
                {
                    MoveFPlayer(rowFPlayer + 1, colFPlayer);
                }
                else if (firstPlayerCommand == "left")
                {
                    MoveFPlayer(rowFPlayer, colFPlayer - 1);
                }
                else if (firstPlayerCommand == "right")
                {
                    MoveFPlayer(rowFPlayer, colFPlayer + 1);
                }

                if (secondPlayerCommand == "up")
                {
                    MoveSPlayer(rowSPlayer - 1, colSPlayer
                        );
                }
                else if (secondPlayerCommand == "down")
                {
                    MoveSPlayer(rowSPlayer + 1, colSPlayer);
                }
                else if (secondPlayerCommand == "left")
                {
                    MoveSPlayer(rowSPlayer, colSPlayer - 1);
                }
                else if (secondPlayerCommand == "right")
                {
                    MoveSPlayer(rowSPlayer, colSPlayer + 1);
                }
            }
        }

        private static void MoveFPlayer(int newRowPosition, int newColPosition)
        {
            if (newColPosition >= matrix.GetLength(1))
            {
                newColPosition = 0;
            }
            else if (newColPosition < 0)
            {
                newColPosition = matrix.GetLength(1) - 1;
            }

            if (newRowPosition >= matrix.GetLength(0))
            {
                newRowPosition = 0;
            }
            else if (newRowPosition < 0)
            {
                newRowPosition = matrix.GetLength(0) - 1;
            }

            if (matrix[newRowPosition, newColPosition] == '*')
            {
                colFPlayer = newColPosition;
                rowFPlayer = newRowPosition;
                matrix[rowFPlayer, colFPlayer] = 'f';
            }
            else if (matrix[newRowPosition, newColPosition] == 's')
            {
                matrix[newRowPosition, newColPosition] = 'x';
                PrintMatrix(matrix);
                Environment.Exit(0);
            }
        }

        private static void MoveSPlayer(int newRowPosition, int newColPosition)
        {
            if (newColPosition >= matrix.GetLength(1))
            {
                newColPosition = 0;
            }
            else if (newColPosition < 0)
            {
                newColPosition = matrix.GetLength(1) - 1;
            }

            if (newRowPosition >= matrix.GetLength(0))
            {
                newRowPosition = 0;
            }
            else if (newRowPosition < 0)
            {
                newRowPosition = matrix.GetLength(0) - 1;
            }

            if (matrix[newRowPosition, newColPosition] == '*')
            {
                colSPlayer = newColPosition;
                rowSPlayer = newRowPosition;
                matrix[rowSPlayer, colSPlayer] = 's';
            }
            else if (matrix[newRowPosition, newColPosition] == 'f')
            {
                matrix[newRowPosition, newColPosition] = 'x';
                PrintMatrix(matrix);
                Environment.Exit(0);
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
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