using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> storage = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }

                string[] splittedInput = input.Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries);

                string shop = splittedInput[0];
                string product = splittedInput[1];
                double price = double.Parse(splittedInput[2]);

                if (!storage.ContainsKey(shop))
                {
                    storage.Add(shop, new Dictionary<string, double>());
                    if (!storage[shop].ContainsKey(product))
                    {
                        storage[shop].Add(product, price);
                    }
                }
                else
                {
                    if (!storage[shop].ContainsKey(product))
                    {
                        storage[shop].Add(product, price);
                    }
                }
            }

            foreach (var kvp in storage)
            {
                var shopName = kvp.Key;
                var products = kvp.Value;

                Console.WriteLine($"{shopName}-> ");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
