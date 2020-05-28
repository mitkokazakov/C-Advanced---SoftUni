using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.__Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            Stack<string> previousOperations = new Stack<string>();

            previousOperations.Push(text.ToString());
            

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                int mainCommand = int.Parse(commands[0]);

                if (mainCommand == 1)
                {
                    string textToAdd = commands[1];
                    text.Append(textToAdd);
                    previousOperations.Push(text.ToString());
                }
                else if (mainCommand == 2)
                {
                    int count = int.Parse(commands[1]);

                    if (text.Length >= count)
                    {
                        //string removedChars = text.Substring(text.Length-count);
                        text.Remove(text.Length - count, count);
                        previousOperations.Push(text.ToString());
                        //Console.WriteLine(removedChars);
                    }

                }
                else if (mainCommand == 3)
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (mainCommand == 4)
                {
                    previousOperations.Pop();
                    text = new StringBuilder();
                    text.Append(previousOperations.Peek());
                }
                

            }
        }
    }
}
