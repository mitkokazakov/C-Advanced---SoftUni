using System;
using System.Linq;

namespace Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();

            StackData<string> stack = new StackData<string>();

            while (commands != "END")
            {
                if (commands.Contains("Push"))
                {
                    string[] inputData = commands.Split(" ", 2);
                    string[] elements = inputData[1].Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    stack.Push(elements);
                }
                else if (commands == "Pop")
                {

                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(String.Join(Environment.NewLine, stack));




        }
    }
}
