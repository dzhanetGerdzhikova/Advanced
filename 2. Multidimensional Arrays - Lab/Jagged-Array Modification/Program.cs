using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] array = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] numsInRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                array[row] = numsInRow;
            }

            string[] splitedInput = Console.ReadLine().Split(' ');
            string command = splitedInput[0].ToUpper();

            while (command != "END")
            {
                int row = int.Parse(splitedInput[1]);
                int col = int.Parse(splitedInput[2]);
                int value = int.Parse(splitedInput[3]);

                if (row < 0 || row >= array.Length || col < 0 || col >= array.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command == "ADD")
                    {
                        array[row][col] += value;
                    }
                    else if (command == "SUBTRACT")
                    {
                        array[row][col] -= value;
                    }
                }

                splitedInput = Console.ReadLine().Split(' ');
                command = splitedInput[0].ToUpper();
            }

            for (int row = 0; row < array.Length; row++)
            {
                Console.WriteLine($"{string.Join(' ', array[row])}");
            }
        }
    }
}