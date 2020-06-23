using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> casualGuests = new HashSet<string>();
            HashSet<string> VIP = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (Char.IsDigit(input[0]))
                {
                    VIP.Add(input);
                }
                else
                {
                    casualGuests.Add(input);
                }
               

                input = Console.ReadLine();
            }

            string guests = Console.ReadLine();

            while (guests != "END")
            {
                if (Char.IsDigit(guests[0]))
                {
                    VIP.Remove(guests);
                }
                else
                {
                    casualGuests.Remove(guests);
                }
                guests = Console.ReadLine();
            }

            Console.WriteLine(VIP.Count + casualGuests.Count);

            if (VIP.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine,VIP));
            }
            if (casualGuests.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, casualGuests));
            }
        }
    }
}
