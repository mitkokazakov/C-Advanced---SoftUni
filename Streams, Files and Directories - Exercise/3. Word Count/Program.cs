using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> words = new HashSet<string>();
            List<string> wordsFromText = new List<string>();
            Dictionary<string, int> countsMatchedWords = new Dictionary<string, int>();

            string pattern = @"[A-Za-z']{1,}";

            string[] inputWords = File.ReadAllLines("words.txt");

            FillTheListWithWords(words, inputWords);

            string text = File.ReadAllText("text.txt").ToLower();

            var filteredText = Regex.Matches(text, pattern);

            AllWordsFromText(wordsFromText, filteredText);

            DetermineCountOfMatchedWords(words, wordsFromText, countsMatchedWords);

            StringBuilder actualResult = new StringBuilder();

            foreach (var (word, count) in countsMatchedWords)
            {
                actualResult.AppendLine(($"{word} - {count}"));
            }

            StringBuilder expectedResult = new StringBuilder();

            foreach (var (word, count) in countsMatchedWords.OrderByDescending(x => x.Value))
            {
                expectedResult.AppendLine(($"{word} - {count}"));
            }

            File.WriteAllText("../../../actualResult.txt",actualResult.ToString());
            File.WriteAllText("../../../expectedResult.txt",expectedResult.ToString());

        }

        private static void DetermineCountOfMatchedWords(HashSet<string> words, List<string> wordsFromText, Dictionary<string, int> countsMatchedWords)
        {
            foreach (var targetWord in words)
            {
                foreach (var word in wordsFromText)
                {
                    if (targetWord == word)
                    {
                        if (!countsMatchedWords.ContainsKey(targetWord))
                        {
                            countsMatchedWords[targetWord] = 0;
                        }
                        countsMatchedWords[targetWord]++;
                    }
                }
            }
        }

        private static void AllWordsFromText(List<string> wordsFromText, MatchCollection filteredText)
        {
            foreach (Match match in filteredText)
            {
                wordsFromText.Add(match.Value);
            }
        }

        private static void FillTheListWithWords(HashSet<string> words, string[] inputWords)
        {
            foreach (var line in inputWords)
            {
                string[] currentLine = line.Split();

                foreach (var word in currentLine)
                {
                    words.Add(word.ToLower());
                }
            }
        }
    }
}
