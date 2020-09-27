using System;

namespace Matrix3
{
    internal class Program
    {
        public static int size;
        public static char[,] matrix;
        public static int firstPlayerRow;
        public static int firstPlayerCol;
        public static int secondlayerRow;
        public static int secondPlayerCol;
        public static string firstPlayercommand;
        public static string secondPlayercommand;

        private static void Main(string[] args)
        {
            size = int.Parse(Console.ReadLine());
            matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        secondlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ');
                firstPlayercommand = commands[0];
                secondPlayercommand = commands[1];
                if (firstPlayercommand == "up")
                {
                    MoveFirstPlayer(firstPlayerRow - 1, firstPlayerCol);
                }
                else if (firstPlayercommand == "down")
                {
                    MoveFirstPlayer(firstPlayerRow + 1, firstPlayerCol);
                }
                else if (firstPlayercommand == "left")
                {
                    MoveFirstPlayer(firstPlayerRow, firstPlayerCol - 1);
                }
                else if (firstPlayercommand == "right")
                {
                    MoveFirstPlayer(firstPlayerRow, firstPlayerCol + 1);
                }

                if (secondPlayercommand == "up")
                {
                    MoveSecondPlayer(secondlayerRow - 1, secondPlayerCol);
                }
                else if (secondPlayercommand == "down")
                {
                    MoveSecondPlayer(secondlayerRow + 1, secondPlayerCol);
                }
                else if (secondPlayercommand == "left")
                {
                    MoveSecondPlayer(secondlayerRow, secondPlayerCol - 1);
                }
                else if (secondPlayercommand == "right")
                {
                    MoveSecondPlayer(secondlayerRow, secondPlayerCol + 1);
                }
            }
        }

        public static bool IsValidCordinate(int row, int col)
        {
            return IsValidRow(row) && IsValidCol(col);
        }

        public static bool IsValidRow(int row)
        {
            return row >= 0 && row < matrix.GetLength(0);
        }

        public static bool IsValidCol(int col)
        {
            return col >= 0 && col < matrix.GetLength(1);
        }

        public static void MoveFirstPlayer(int newRow, int newCol)
        {
            if (IsValidCordinate(newRow, newCol))
            {
                if (matrix[newRow, newCol] == '*')
                {
                    matrix[newRow, newCol] = 'f';
                    firstPlayerRow = newRow;
                    firstPlayerCol = newCol;
                }
                else if (matrix[newRow, newCol] == 's')
                {
                    matrix[newRow, newCol] = 'x';
                    PrintMatrix();
                    Environment.Exit(0);
                }
            }
            else
            {
                if (firstPlayercommand == "up")
                {
                    MoveFirstPlayer(size - 1, newCol);
                }
                else if (firstPlayercommand == "down")
                {
                    MoveFirstPlayer(0, newCol);
                }
                else if (firstPlayercommand == "left")
                {
                    MoveFirstPlayer(newRow, size - 1);
                }
                else if (firstPlayercommand == "right")
                {
                    MoveFirstPlayer(newRow, 0);
                }
            }
        }

        public static void MoveSecondPlayer(int newRow, int newCol)
        {
            if (IsValidCordinate(newRow, newCol))
            {
                if (matrix[newRow, newCol] == '*')
                {
                    matrix[newRow, newCol] = 's';
                    secondlayerRow = newRow;
                    secondPlayerCol = newCol;
                }
                else if (matrix[newRow, newCol] == 'f')
                {
                    matrix[newRow, newCol] = 'x';
                    PrintMatrix();
                    Environment.Exit(0);
                }
            }
            else
            {
                if (secondPlayercommand == "up")
                {
                    MoveSecondPlayer(size - 1, newCol);
                }
                else if (secondPlayercommand == "down")
                {
                    MoveSecondPlayer(0, newCol);
                }
                else if (secondPlayercommand == "left")
                {
                    MoveSecondPlayer(newRow, size - 1);
                }
                else if (secondPlayercommand == "right")
                {
                    MoveSecondPlayer(newRow, 0);
                }
            }
        }

        public static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}