using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Present_Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> material = new Stack<int>(firstLine);
            Queue<int> magicLevel = new Queue<int>(secondLine);

            const int dollMagic = 150;
            const int trainMagic = 250;
            const int bearMagic = 300;
            const int bicycleMagic = 400;

            Dictionary<string, int> presents = new Dictionary<string, int>
            {
                { "Doll",0 },
                {"Wooden train",0 },
                { "Teddy bear",0},
                { "Bicycle",0}
            };
            while (material.Any() && magicLevel.Any())
            {
                int currentMaterial = material.Peek();
                int currentMagicLevel = magicLevel.Peek();
                int result = currentMaterial * currentMagicLevel;
                bool newCraft = false;
                if (currentMaterial == 0)
                {
                    material.Pop();
                    newCraft = true;
                }
                if (currentMagicLevel == 0)
                {
                    magicLevel.Dequeue();
                    newCraft = true;
                }
                if (newCraft)
                {
                    continue;
                }

                material.Pop();
                magicLevel.Dequeue();
                switch (result)
                {
                    case dollMagic:
                        presents["Doll"]++;
                        break;

                    case trainMagic:

                        presents["Wooden train"]++;
                        break;

                    case bearMagic:

                        presents["Teddy bear"]++;
                        break;

                    case bicycleMagic:

                        presents["Bicycle"]++;
                        break;

                    default:
                        if (result < 0)
                        {
                            int newResult = currentMaterial + currentMagicLevel;

                            material.Push(newResult);
                        }
                        else if (result > 0)
                        {
                            material.Push(currentMaterial + 15);
                        }
                        break;
                }
            }
            if ((presents["Doll"] > 0 && presents["Wooden train"] > 0) || (presents["Teddy bear"] > 0 && presents["Bicycle"] > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (material.Any())
            {
                Console.WriteLine($"Materials left: { string.Join(", ", material)}");
            }
            if (magicLevel.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}");
            }
            foreach (var present in presents.OrderBy(p => p.Key).Where(p => p.Value > 0))
            {
                Console.WriteLine($"{present.Key}: {present.Value}");
            }
        }
    }
}