using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLine = int.Parse(Console.ReadLine());

            Stack<string> stackTextCommands = new Stack<string>();

            string emptyText = string.Empty;

            for (int i = 0; i < countLine; i++)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "1":
                        string addedText = commands[1];
                        stackTextCommands.Push(emptyText);
                        emptyText += addedText;
                        break;

                    case "2":
                        int errasesEl = int.Parse(commands[1]);
                        stackTextCommands.Push(emptyText);
                        emptyText = emptyText.Substring(0, emptyText.Length - errasesEl);
                        break;

                    case "3":
                        int posicionOfPrintEl = int.Parse(commands[1]);
                        Console.WriteLine(emptyText[posicionOfPrintEl - 1]);
                        break;

                    case "4":
                        emptyText = stackTextCommands.Pop();
                        break;
                }
            }
        }
    }
}