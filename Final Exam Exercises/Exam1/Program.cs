using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> bombsEffects = new Queue<int>(firstInput);
            Stack<int> bombsCasings = new Stack<int>(secondInput);

            Dictionary<string, int> materials = new Dictionary<string, int>
            {
                { "Datura Bombs",40 },
                { "Cherry Bombs",60},
                { "Smoke Decoy Bombs",120}
            };

            Dictionary<string, int> bombPouch = new Dictionary<string, int>
            {
                  { "Datura Bombs",0 },
                { "Cherry Bombs",0},
                { "Smoke Decoy Bombs",0}
            };
            int countDatura = 0;
            int countCherry = 0;
            int countSmoke = 0;

            bool haveBombPouch = false;

            while (bombsEffects.Any() && bombsCasings.Any())
            {
                int currentEffects = bombsEffects.Peek();
                int currentCasing = bombsCasings.Peek();
                int currentSum = currentEffects + currentCasing;

                if (currentSum == materials["Datura Bombs"])
                {
                    bombPouch["Datura Bombs"]++;
                    countDatura++;
                    bombsEffects.Dequeue();
                    bombsCasings.Pop();
                }
                else if (currentSum == materials["Cherry Bombs"])
                {
                    bombPouch["Cherry Bombs"]++;
                    countCherry++;
                    bombsEffects.Dequeue();
                    bombsCasings.Pop();
                }
                else if (currentSum == materials["Smoke Decoy Bombs"])
                {
                    bombPouch["Smoke Decoy Bombs"]++;
                    countSmoke++;
                    bombsEffects.Dequeue();
                    bombsCasings.Pop();
                }
                else
                {
                    bombsCasings.Pop();
                    bombsCasings.Push(currentCasing - 5);
                }

                if (countDatura >= 3 && countCherry >= 3 && countSmoke >= 3)
                {
                    haveBombPouch = true;
                    break;
                }
            }

            if (!haveBombPouch)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            else
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }

            if (bombsEffects.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombsEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombsCasings.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombsCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {countCherry}");
            Console.WriteLine($"Datura Bombs: {countDatura}");
            Console.WriteLine($"Smoke Decoy Bombs: {countSmoke}");
        }
    }
}