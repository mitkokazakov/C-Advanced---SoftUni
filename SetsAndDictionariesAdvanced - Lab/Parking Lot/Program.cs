using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> registration = new HashSet<string>();

            while (input != "END")
            {
                string[] inputInfo = input.Split(", ");
                string direction = inputInfo[0];
                string regNum = inputInfo[1];

                if (direction == "IN")
                {
                    registration.Add(regNum);
                }
                else if (direction == "OUT")
                {
                    registration.Remove(regNum);
                }

                input = Console.ReadLine();
            }

            if (registration.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(String.Join(Environment.NewLine, registration));
            }
        }
    }
}
