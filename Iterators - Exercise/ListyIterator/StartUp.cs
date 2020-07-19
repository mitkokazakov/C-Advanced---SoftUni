using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine().Split(" ").Skip(1).ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(inputData);

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                if (commands == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception message)
                    {

                        Console.WriteLine(message.Message);
                    }
                }
                else if (commands == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext()); ;
                }
                else if (commands == "Move")
                {
                    Console.WriteLine(listyIterator.Move()); ;
                }
                else if (commands == "PrintAll")
                {
                    Console.WriteLine(String.Join(" ",listyIterator));
                }
                commands = Console.ReadLine();
            }
        }
    }
}
