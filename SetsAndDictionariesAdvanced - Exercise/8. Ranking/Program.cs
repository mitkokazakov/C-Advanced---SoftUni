using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] contestInfo = input.Split(":");
                string contestName = contestInfo[0];
                string password = contestInfo[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = password;
                }
                input = Console.ReadLine();
            }

            string candidateInput = Console.ReadLine();

            while (candidateInput != "end of submissions")
            {
                string[] candidateInfo = candidateInput.Split("=>");
                string contest = candidateInfo[0];
                string pass = candidateInfo[1];
                string student = candidateInfo[2];
                int points = int.Parse(candidateInfo[3]);

                if (contests.ContainsKey(contest) && contests[contest] == pass)
                {
                    if (!candidates.ContainsKey(student))
                    {
                        candidates[student] = new Dictionary<string, int>();
                        candidates[student][contest] = 0;

                    }

                    if (candidates.ContainsKey(student) && !candidates[student].ContainsKey(contest))
                    {
                        candidates[student][contest] = 0;
                    }

                    if (candidates.ContainsKey(student))
                    {
                        if (candidates[student][contest] < points)
                        {
                            candidates[student][contest] = points;
                        }
                        
                    }
                }

                candidateInput = Console.ReadLine();
            }

            var bestCandidate = candidates.OrderByDescending(x => x.Value.Values.Sum()).Take(1);

            foreach (var (student,points) in bestCandidate)
            {
                Console.WriteLine($"Best candidate is {student} with total {points.Values.Sum()} points.");
            }

            Console.WriteLine($"Ranking:");

            foreach (var (student,info) in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine(student);

                foreach (var (contest,points) in info.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}
