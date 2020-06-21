using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            while (input != "Revision")
            {
                string[] inputInfo = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string marketName = inputInfo[0];
                string product = inputInfo[1];
                double price = double.Parse(inputInfo[2]);

                if (!shops.ContainsKey(marketName))
                {
                    shops[marketName] = new Dictionary<string, double>();
                }

                if (!shops[marketName].ContainsKey(product))
                {
                    shops[marketName][product] = price;
                }
                

                input = Console.ReadLine();
            }

            foreach (var (key,value) in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}->");

                foreach (var (product,price) in value)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
