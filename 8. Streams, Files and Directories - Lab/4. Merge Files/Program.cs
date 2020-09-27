using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _4._Merge_Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using StreamReader input1 = new StreamReader("Input1.txt");
            using StreamReader input2 = new StreamReader("Input2.txt");
            using StreamWriter output = new StreamWriter("Output.txt");
            List<int> finallyResult = new List<int>();

            while (true)
            {
                bool isNumber = int.TryParse(input1.ReadLine(), out int number);

                if (!isNumber)
                {
                    break;
                }
                finallyResult.Add(number);
            }

            while (true)
            {
                bool isNumber = int.TryParse(input2.ReadLine(), out int number);

                if (!isNumber)
                {
                    break;
                }
                finallyResult.Add(number);
            }

            foreach (var currentNum in finallyResult.OrderBy(x => x))
            {
                output.WriteLine(currentNum);
            }
        }
    }
}