using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (currentChar == '(')
                {
                    indexes.Push(i);
                }
                else if (currentChar == ')')
                {
                    int startIndex = indexes.Pop();
                    string content = text.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(content);
                }
            }
        }
    }
}
