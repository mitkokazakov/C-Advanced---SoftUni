using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.__Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(input);
            // Possible error if the count of the commands is lower than the count of elements in the queue
            while (songs.Any())
            {
                string[] commands = Console.ReadLine().Split(" ", 2);
                string mainCommand = commands[0];

                if (mainCommand == "Play")
                {
                    songs.Dequeue();
                }
                else if (mainCommand == "Add")
                {
                    string songToAdd = commands[1];

                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                    
                }
                else if (mainCommand == "Show")
                {
                    Console.WriteLine(String.Join(", ",songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
