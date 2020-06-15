using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string name = inputInfo[0];
                decimal grade = decimal.Parse(inputInfo[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<decimal>();
                }

                grades[name].Add(grade);
            }

            foreach (var (key,value) in grades)
            {
                Console.Write($"{key} -> ");

                foreach (var grade in value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {value.Average():f2})");
            }
        }
    }
}
