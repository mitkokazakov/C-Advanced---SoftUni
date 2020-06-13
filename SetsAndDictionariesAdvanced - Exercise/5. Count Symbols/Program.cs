using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> countSymbols = new Dictionary<char, int>();

            string text = Console.ReadLine();

            foreach (var symbol in text)
            {
                if (!countSymbols.ContainsKey(symbol))
                {
                    countSymbols[symbol] = 0;
                }
                countSymbols[symbol]++;
            }

            foreach (var (symbol,count) in countSymbols.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbol}: {count} time/s");
            }
        }
    }
}
