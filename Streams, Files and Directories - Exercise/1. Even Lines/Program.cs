using System;
using System.IO;
using System.Linq;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                int counter = 0;
                string[] symbols = { "-", ",", ".", "!", "?" };

                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();

                    if (counter % 2 == 0)
                    {
                        currentLine = ReplaceSymbols(symbols, currentLine);
                        string[] finalResult = currentLine.Split().Reverse().ToArray();
                        Console.WriteLine(String.Join(" ",finalResult));
                    }
                    counter++;
                }
            }
        }

        private static string ReplaceSymbols(string[] symbols, string currentLine)
        {
            foreach (var symbol in currentLine)
            {
                string currentSymbol = symbol.ToString();
                if (symbols.Contains(currentSymbol))
                {
                    currentLine = currentLine.Replace(currentSymbol, "@");
                }
            }

            return currentLine;
        }
    }
}
