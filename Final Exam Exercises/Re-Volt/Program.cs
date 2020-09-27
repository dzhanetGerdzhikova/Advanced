using System;

namespace Re_Volt
{
    internal class Program
    {
        public static int size;
        public static char[,] matrix;
        public static int playerRow;
        public static int playerCol;
        public static string command;

        private static void Main(string[] args)
        {
            size = int.Parse(Console.ReadLine());

            int countCommand = int.Parse(Console.ReadLine());
            matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            while (countCommand > 0)
            {
                command = Console.ReadLine();
                countCommand--;
                if (command == "up")
                {
                    MovePlayer(playerRow - 1, playerCol);
                }
                else if (command == "right")
                {
                    MovePlayer(playerRow, playerCol + 1);
                }
                else if (command == "left")
                {
                    MovePlayer(playerRow, playerCol - 1);
                }
                else if (command == "down")
                {
                    MovePlayer(playerRow + 1, playerCol);
                }
            }

            matrix[playerRow, playerCol] = 'f';
            Console.WriteLine("Player lost!");
            Print();
        }

        private static void Print()
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

        public static void MovePlayer(int newRow, int newCol)
        {
            if (IsValidCordinates(newRow, newCol))
            {
                if (matrix[newRow, newCol] == '-')
                {
                    matrix[playerRow, playerCol] = '-';
                    playerRow = newRow;
                    playerCol = newCol;
                }
                else if (matrix[newRow, newCol] == 'B')
                {
                    //var diffCol = newCol - playerCol;
                    //var diffRow = newRow - playerRow;

                    //MovePlayer(newRow + diffRow, newCol + diffCol);
                    matrix[playerRow, playerCol] = '-';
                    playerRow = newRow;
                    playerRow = newCol;

                    if (command == "up")
                    {
                        MovePlayer(newRow - 1, newCol);
                    }
                    else if (command == "down")
                    {
                        MovePlayer(newRow + 1, newCol);
                    }
                    else if (command == "left")
                    {
                        MovePlayer(newRow, newCol - 1);
                    }
                    else if (command == "right")
                    {
                        MovePlayer(newRow, newCol + 1);
                    }
                }
                else if (matrix[newRow, newCol] == 'F')
                {
                    matrix[playerRow, playerCol] = '-';
                    playerRow = newRow;
                    playerCol = newCol;
                    matrix[playerRow, playerCol] = 'f';
                    Console.WriteLine("Player won!");
                    Print();
                    Environment.Exit(0);
                }
            }
            else
            {
                if (newRow >= size)
                {
                    MovePlayer(0, newCol);
                }
                if (newRow < 0)
                {
                    MovePlayer(size - 1, newCol);
                }
                if (newCol >= size)
                {
                    MovePlayer(newRow, 0);
                }
                if (newCol < 0)
                {
                    MovePlayer(newRow, size - 1);
                }
            }
        }

        public static bool IsValidCordinates(int newRow, int newCol)
        {
            return IsRowValid(newRow) && IsColValid(newCol);
        }

        public static bool IsRowValid(int row)
        {
            return row >= 0 && row < size;
        }

        public static bool IsColValid(int col)
        {
            return col >= 0 && col < size;
        }
    }
}