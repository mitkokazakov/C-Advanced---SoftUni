using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandArgs = command.Split();
                string mainCommand = commandArgs[0];
                string operation = commandArgs[1];
                int length = 0;
                string targetWord = String.Empty;

                bool canBeParsed = int.TryParse(commandArgs[2], out length);

                if (!canBeParsed)
                {
                    targetWord = commandArgs[2];
                }

                Predicate<string> predicateForStart = lett => lett.StartsWith(targetWord);
                Predicate<string> predicateForEnd = lett => lett.EndsWith(targetWord);
                Predicate<int> predicateForLength = len => len == length;

                if (mainCommand == "Remove")
                {
                    RemovingGuests(guest, operation, predicateForStart, predicateForEnd, predicateForLength);
                }
                else if (mainCommand == "Double")
                {
                    DoubleTheGuest(guest, operation, predicateForStart, predicateForEnd, predicateForLength);

                }

                command = Console.ReadLine();
            }

            if (guest.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(String.Join(", ", guest));
                Console.WriteLine(" are going to the party!");
            }
            
        }

        private static void DoubleTheGuest(List<string> guest, string operation, Predicate<string> predicateForStart, Predicate<string> predicateForEnd, Predicate<int> predicateForLength)
        {
            if (operation == "StartsWith")
            {
                for (int i = 0; i < guest.Count; i++)
                {
                    string currentGuest = guest[i];

                    if (predicateForStart(currentGuest))
                    {
                        guest.Insert(i + 1, currentGuest);
                        i++;
                    }
                }
            }
            else if (operation == "EndsWith")
            {
                for (int i = 0; i < guest.Count; i++)
                {
                    string currentGuest = guest[i];

                    if (predicateForEnd(currentGuest))
                    {
                        guest.Insert(i + 1, currentGuest);
                        i++;
                    }
                }
            }
            else if (operation == "Length")
            {
                for (int i = 0; i < guest.Count; i++)
                {
                    string currentGuest = guest[i];

                    if (predicateForLength(currentGuest.Length))
                    {
                        guest.Insert(i + 1, currentGuest);
                        i++;
                    }
                }
            }
        }

        private static void RemovingGuests(List<string> guest, string operation, Predicate<string> predicateForStart, Predicate<string> predicateForEnd, Predicate<int> predicateForLength)
        {
            if (operation == "StartsWith")
            {
                for (int i = 0; i < guest.Count; i++)
                {
                    string currentGuest = guest[i];

                    if (predicateForStart(currentGuest))
                    {
                        guest.Remove(currentGuest);
                        i--;
                    }
                }
            }
            else if (operation == "EndsWith")
            {
                for (int i = 0; i < guest.Count; i++)
                {
                    string currentGuest = guest[i];

                    if (predicateForEnd(currentGuest))
                    {
                        guest.Remove(currentGuest);
                        i--;
                    }
                }
            }
            else if (operation == "Length")
            {
                for (int i = 0; i < guest.Count; i++)
                {
                    string currentGuest = guest[i];

                    if (predicateForLength(currentGuest.Length))
                    {
                        guest.Remove(currentGuest);
                        i--;
                    }
                }
            }
        }



    }
}
