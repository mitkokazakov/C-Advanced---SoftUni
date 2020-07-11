using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int left = 5;
            int right = 10;

            EqualityScale<int> scale = new EqualityScale<int>(left, right);

            var result = scale.AreEqual();

            Console.WriteLine(result);
        }
    }
}
