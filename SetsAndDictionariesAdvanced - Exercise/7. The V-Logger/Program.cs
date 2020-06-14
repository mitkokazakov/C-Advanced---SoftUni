using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> vloggers = new Dictionary<string, int[]>();
            Dictionary<string, HashSet<string>> followers = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] inputInfo = input.Split();
                string name = inputInfo[0];
                string command = inputInfo[1];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(name))
                    {
                        vloggers[name] = new int[2];
                        followers[name] = new HashSet<string>();
                    }
                }
                else if (command == "followed")
                {
                    string firstVlogger = inputInfo[0];
                    string secondVlogger = inputInfo[2];

                    if (vloggers.ContainsKey(firstVlogger) && vloggers.ContainsKey(secondVlogger))
                    {
                        if (firstVlogger != secondVlogger && !followers[secondVlogger].Contains(firstVlogger))
                        {
                            vloggers[secondVlogger][0]++;
                            vloggers[firstVlogger][1]++;
                            followers[secondVlogger].Add(firstVlogger);
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            var bestVlogger = vloggers.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]).Take(1);
            string nameBestVlogger = String.Empty;

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            foreach (var (vlogger,follow) in bestVlogger)
            {
                nameBestVlogger = vlogger;
                Console.WriteLine($"1. {vlogger} : {follow[0]} followers, {follow[1]} following");
            }

            foreach (var (vlogger,follower) in followers)
            {
                if (vlogger == nameBestVlogger)
                {
                    foreach (var person in follower.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {person}");
                    }
                }
            }

            var restVloggers = vloggers.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]).Skip(1);
            int count = 1;

            foreach (var (vlogger,info) in restVloggers)
            {
                count++;
                Console.WriteLine($"{count}. {vlogger} : {info[0]} followers, {info[1]} following");
            }
        }
    }
}
