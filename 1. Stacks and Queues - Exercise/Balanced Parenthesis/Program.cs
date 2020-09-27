using System;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> oppenBracket = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                char currentEl = input[i];

                if (currentEl == '(' || currentEl == '[' || currentEl == '{')
                {
                    oppenBracket.Push(currentEl);
                }
                else if (oppenBracket.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    char oppenBr = oppenBracket.Pop();
                    if (currentEl == ')' && oppenBr != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else if (currentEl == ']' && oppenBr != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else if (currentEl == '}' && oppenBr != '{')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}