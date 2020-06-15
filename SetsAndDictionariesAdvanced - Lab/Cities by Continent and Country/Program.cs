using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFLInes = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < numOFLInes; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string continent = inputInfo[0];
                string country = inputInfo[1];
                string town = inputInfo[2];

                if (!countries.ContainsKey(continent))
                {
                    countries[continent] = new Dictionary<string, List<string>>();
                }

                if (!countries[continent].ContainsKey(country))
                {
                    countries[continent][country] = new List<string>();
                }

                countries[continent][country].Add(town);
            }

            foreach (var (key,value) in countries)
            {
                Console.WriteLine($"{key}:");

                foreach (var (country,towns) in value)
                {
                    Console.WriteLine($" {country} -> {String.Join(", ",towns)}");
                }
                //Console.WriteLine();
            }
        }
    }
}
