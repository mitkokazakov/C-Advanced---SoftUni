using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            int len = input.Length;

            Stack<char> stack = new Stack<char>();

            if (len % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                for (int i = 0; i < len; i++)
                {
                    char currentChar = input[i];

                    if (currentChar == '{' || currentChar == '[' || currentChar == '(')
                    {
                        stack.Push(currentChar);
                    }
                    else if (currentChar == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                        counter++;
                    }
                    else if(currentChar == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                        counter++;
                    }
                    else if (currentChar == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                        counter++;
                    }
                }

                if (counter == len/2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            
            

            

        }
    }
}
