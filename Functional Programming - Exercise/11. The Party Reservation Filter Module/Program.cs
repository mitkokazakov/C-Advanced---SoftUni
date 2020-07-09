using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> filters = new List<string>();

            string input = Console.ReadLine();

            while (input != "Print")
            {
                DetermineFilters(filters, input);
                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] filterInfo = filter.Split("+");
                string currentType = filterInfo[0];
                string currentCriteria = filterInfo[1];

                names = ProcessNames(names, currentType, currentCriteria);
            }

            Console.WriteLine(String.Join(" ",names));
        }

        private static List<string> ProcessNames(List<string> names, string currentType, string currentCriteria)
        {
            if (currentType == "Ends with")
            {
                names = names.Where(n => !n.EndsWith(currentCriteria)).ToList();
            }
            else if (currentType == "Starts with")
            {
                names = names.Where(n => !n.StartsWith(currentCriteria)).ToList();
            }
            else if (currentType == "Length")
            {
                int currentCriteriaAsNum = int.Parse(currentCriteria);
                names = names.Where(n => n.Length != currentCriteriaAsNum).ToList();
            }
            else if (currentType == "Contains")
            {
                names = names.Where(n => !n.Contains(currentCriteria)).ToList();
            }

            return names;
        }

        private static void DetermineFilters(List<string> filters, string input)
        {
            string[] filterInfo = input.Split(";");
            string command = filterInfo[0];
            string filterType = filterInfo[1];
            string criteria = filterInfo[2];
            if (command.Contains("Add"))
            {
                filters.Add(filterType + "+" + criteria);
            }
            else if (command.Contains("Remove"))
            {
                filters.Remove(filterType + "+" + criteria);
            }
        }
    }
}
