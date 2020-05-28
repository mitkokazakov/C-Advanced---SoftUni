using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            Stack<string> calculator = new Stack<string>(input.Reverse());

            while (calculator.Count > 1)
            {
                int result = 0;
                int firstNum = int.Parse(calculator.Pop());
                string operations = calculator.Pop();
                int secondNum = int.Parse(calculator.Pop());
                if (operations == "+")
                {
                    result = firstNum + secondNum;
                }
                else if (operations == "-")
                {
                    result = firstNum - secondNum;
                }
                
                calculator.Push(result.ToString());
            }

            Console.WriteLine(calculator.Pop());
        }
    }
}
