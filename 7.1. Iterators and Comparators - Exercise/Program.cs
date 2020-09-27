using ListyIteratort;
using System;
using System.Linq;

namespace ListyIterator

{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Skip(1).ToArray();
            ListyIterator<string> list = new ListyIterator<string>(input.ToList());

            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command == "Print")
                {
                    try
                    {
                        list.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (command == "PrintAll")
                {
                    foreach (var element in list)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
        }
    }
}