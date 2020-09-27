using System;
using System.Linq;

namespace Present_Delivery
{
    internal class Program
    {
        private static char[,] matrix;
        private static int rowS = 0;
        private static int colS = 0;
        private static int countNiceKids = 0;
        private static int givePresents = 0;
        private static int givePresentToNiceKids = 0;
        private static int maxPresentsToGive;
        private static int sizeOfMatrix;

        private static void Main(string[] args)
        {
            maxPresentsToGive = int.Parse(Console.ReadLine());
            sizeOfMatrix = int.Parse(Console.ReadLine());

            matrix = new char[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    if (input[col] == 'S')
                    {
                        rowS = row;
                        colS = col;
                    }
                    else if (input[col] == 'V')
                    {
                        countNiceKids++;
                    }
                    matrix[row, col] = input[col];
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "Christmas morning" && givePresents < maxPresentsToGive)
            {
                if (command == "up")
                {
                    MoveSanta(rowS - 1, colS);
                }
                else if (command == "down")
                {
                    MoveSanta(rowS + 1, colS);
                }
                else if (command == "right")
                {
                    MoveSanta(rowS, colS + 1);
                }
                else if (command == "left")
                {
                    MoveSanta(rowS, colS - 1);
                }
            }

            if (givePresents >= maxPresentsToGive)
            {
                Console.WriteLine("Santa ran out of presents!");
            }

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            if (givePresentToNiceKids < countNiceKids)
            {
                Console.WriteLine($"No presents for {countNiceKids - givePresentToNiceKids} nice kid/s.");
            }
            else
            {
                Console.WriteLine($"Good job, Santa! {givePresentToNiceKids} happy nice kid/s.");
            }
        }

        public static void MoveSanta(int newRow, int newCol)
        {
            if (matrix[newRow, newCol] == 'V')
            {
                givePresents++;
                givePresentToNiceKids++;
            }
            else if (matrix[newRow, newCol] == 'C')
            {
                GivePresent(newRow - 1, newCol); //up
                GivePresent(newRow, newCol + 1); //right
                GivePresent(newRow + 1, newCol); //down
                GivePresent(newRow, newCol - 1); //left
            }

            matrix[newRow, newCol] = 'S';
            matrix[rowS, colS] = '-';
            rowS = newRow;
            colS = newCol;
        }

        public static void GivePresent(int newRow, int newCol)
        {
            if (matrix[newRow, newCol] == 'V')
            {
                givePresents++;
                givePresentToNiceKids++;
            }
            else if (matrix[newRow, newCol] == 'X')
            {
                givePresents++;
            }
            matrix[newRow, newCol] = '-';
        }
    }
}