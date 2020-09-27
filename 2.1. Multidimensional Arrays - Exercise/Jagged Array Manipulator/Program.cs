using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countRow = int.Parse(Console.ReadLine());

            double[][] array = new double[countRow][];

            for (int row = 0; row < countRow; row++)
            {
                double[] numsInRow = ReadArrayFromConsole(' ').Select(double.Parse).ToArray();

                array[row] = numsInRow;
            }

            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                if (array[row].Length == array[row + 1].Length)
                {
                    array[row] = array[row].Select(e => e * 2).ToArray();
                    array[row + 1] = array[row + 1].Select(e => e * 2).ToArray();
                }
                else
                {
                    array[row] = array[row].Select(e => e / 2).ToArray();
                    array[row + 1] = array[row + 1].Select(e => e / 2).ToArray();
                }
            }
            string[] input = ReadArrayFromConsole();
            string command = input[0];

            while (command != "End")
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array[row].Length)
                {
                    if (command == "Add")
                    {
                        array[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        array[row][col] -= value;
                    }
                }
                else
                {
                    input = ReadArrayFromConsole();
                    command = input[0];
                    continue;
                }

                input = ReadArrayFromConsole();
                command = input[0];
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(' ', array[row]));
            }
        }

        private static string[] ReadArrayFromConsole(params char[] separator)
        {
            return Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}