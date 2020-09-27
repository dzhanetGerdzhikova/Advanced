using System;

namespace Pascal_Triangle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long[][] array = new long[n][];

            for (long row = 0; row < n; row++)
            {
                array[row] = new long[row + 1];

                for (long col = 0; col < row + 1; col++)
                {
                    if (col == 0 || col == row)
                    {
                        array[row][col] = 1;
                    }
                    else
                    {
                        array[row][col] = array[row - 1][col] + array[row - 1][col - 1];
                    }
                }
            }

            for (long row = 0; row < array.Length; row++)
            {
                Console.WriteLine($"{string.Join(' ', array[row])}");
            }
        }
    }
}