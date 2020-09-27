using System;
using System.Collections.Generic;
using System.Linq;

namespace Dating_App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] males = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] females = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> malesS = new Stack<int>(males);
            Queue<int> femalesQ = new Queue<int>(females);

            int counter = 0;

            while (malesS.Any() && femalesQ.Any())
            {
                int currentMale = malesS.Peek();
                int currentFemale = femalesQ.Peek();

                if (currentMale <= 0)
                {
                    malesS.Pop();
                    continue;
                }
                if (currentFemale <= 0)
                {
                    femalesQ.Dequeue();
                    continue;
                }
                if (currentFemale % 25 == 0)
                {
                    femalesQ.Dequeue();
                    if (femalesQ.Any())
                    {
                        femalesQ.Dequeue();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentMale % 25 == 0)
                {
                    malesS.Pop();
                    if (malesS.Any())
                    {
                        malesS.Pop();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentFemale == currentMale)
                {
                    malesS.Pop();
                    femalesQ.Dequeue();
                    counter++;
                }
                else
                {
                    femalesQ.Dequeue();
                    malesS.Pop();
                    malesS.Push(currentMale - 2);
                }
            }
            Console.WriteLine($"Matches: {counter}");
            string malesText = malesS.Any() ? $"Males left: { string.Join(", ", malesS)}" : "Males left: none";
            string femalesText = femalesQ.Any() ? $"Females left: {string.Join(", ", femalesQ)}" : "Females left: none";
            Console.WriteLine(malesText);
            Console.WriteLine(femalesText);
        }
    }
}