using System;
using System.Collections.Generic;

namespace BoxOfT

{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int input = 258;

            box.Add(input);
            box.Add(input);
            box.Add(input);
            box.Add(input);
            box.Add(input);
            //var result = box.Remove();

            Console.WriteLine(box);
        }
    }
}
