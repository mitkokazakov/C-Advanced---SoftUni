using System;
using System.Linq;

namespace TupleGeneric
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInputInfo = Console.ReadLine().Split();

            string name = $"{firstInputInfo[0]} {firstInputInfo[1]}";
            string adress = firstInputInfo[2];

            string[] secondInputInfo = Console.ReadLine().Split();

            string name1 = secondInputInfo[0];
            int liters = int.Parse(secondInputInfo[1]);

            string[] thirdInputInfo = Console.ReadLine().Split();

            int n = int.Parse(thirdInputInfo[0]);
            double d = double.Parse(thirdInputInfo[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(name,adress);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name1, liters);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(n, d);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

        }
    }
}
