using System;

namespace Exam3
{
    internal class Program
    {
        public static int size;
        public static char[,] matrix;
        public static int snakeRow;
        public static int snakeCol;
        public static int firstRowB = -1;
        public static int firstColB = -1;
        public static int secondRowB;
        public static int secondColB;
        public static int eatFood = 0;

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

                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (matrix[row, col] == 'B' && firstRowB == -1 && firstColB == -1)
                    {
                        firstRowB = row;
                        firstColB = col;
                    }

                    if (matrix[row, col] == 'B' && row != firstRowB && col != firstColB)
                    {
                        secondRowB = row;
                        secondColB = col;
                    }
                }
            }

            while (eatFood < 10)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    MoveSnake(snakeRow - 1, snakeCol);
                }
                else if (command == "down")
                {
                    MoveSnake(snakeRow + 1, snakeCol);
                }
                else if (command == "left")
                {
                    MoveSnake(snakeRow, snakeCol - 1);
                }
                else if (command == "right")
                {
                    MoveSnake(snakeRow, snakeCol + 1);
                }
            }
            Console.WriteLine("You won! You fed the snake.");
            Console.WriteLine($"Food eaten: {eatFood}");
            PrintMatrix();
        }

        public static bool IsValidCordinate(int row, int col)
        {
            return IsValidRow(row) && IsValidCol(col);
        }

        public static bool IsValidRow(int row)
        {
            return row >= 0 && row < size;
        }

        public static bool IsValidCol(int col)
        {
            return col >= 0 && col < size;
        }

        public static void MoveSnake(int newRow, int newCol)
        {
            if (IsValidCordinate(newRow, newCol))
            {
                matrix[snakeRow, snakeCol] = '.';

                if (matrix[newRow, newCol] == '*')
                {
                    matrix[newRow, newCol] = 'S';
                    snakeRow = newRow;
                    snakeCol = newCol;
                    eatFood++;
                }
                else if (matrix[newRow, newCol] == '-')
                {
                    matrix[newRow, newCol] = 'S';
                    snakeRow = newRow;
                    snakeCol = newCol;
                }
                else if (matrix[newRow, newCol] == 'B')
                {
                    matrix[newRow, newCol] = '.';
                    if (newRow == firstRowB && newCol == firstColB)
                    {
                        snakeRow = secondRowB;
                        snakeCol = secondColB;
                    }
                    else if (newRow == secondRowB && newCol == secondColB)
                    {
                        snakeRow = firstRowB;
                        snakeCol = firstColB;
                    }
                    matrix[snakeRow, snakeCol] = 'S';
                }
            }
            else
            {
                matrix[snakeRow, snakeCol] = '.';
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {eatFood}");
                PrintMatrix();
                Environment.Exit(0);
            }
        }

        public static void PrintMatrix()
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}