using System;
using System.IO;
using System.Linq;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("text.txt");

            for (int i = 0; i < inputLines.Length; i++)
            {
                string line = inputLines[i];

                int countLetters = 0;
                int countPunctoationMarks = 0;

                countLetters = CountingTheLetters(line, countLetters);

                countPunctoationMarks = CountingPunctuationMarks(line, countPunctoationMarks);

                inputLines[i] = $"Line {i+1}: {line} ({countLetters})({countPunctoationMarks})";
            }

            File.WriteAllLines("../../../output.txt",inputLines);
        }

        private static int CountingPunctuationMarks(string line, int countPunctoationMarks)
        {
            foreach (var symbol in line)
            {
                if (Char.IsPunctuation(symbol))
                {
                    countPunctoationMarks++;
                }
            }

            return countPunctoationMarks;
        }

        private static int CountingTheLetters(string line, int countLetters)
        {
            foreach (var symbol in line)
            {
                if (Char.IsLetter(symbol))
                {
                    countLetters++;
                }
            }

            return countLetters;
        }
    }
}
