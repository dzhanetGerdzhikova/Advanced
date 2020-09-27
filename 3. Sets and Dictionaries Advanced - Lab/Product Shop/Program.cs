using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                string[] inputInfo = input.Split(", ");
                string nameShop = inputInfo[0];
                string product = inputInfo[1];
                double price = double.Parse(inputInfo[2]);

                if (!shops.ContainsKey(nameShop))
                {
                    shops.Add(nameShop, new Dictionary<string, double>());
                }
                shops[nameShop][product] = price;

                input = Console.ReadLine();
            }

            foreach (var (shopName, shopProducts) in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shopName}->");

                foreach (var (productName, productPrice) in shopProducts)
                {
                    Console.WriteLine($"Product: {productName}, Price: {productPrice}");
                }
            }
        }
    }
}