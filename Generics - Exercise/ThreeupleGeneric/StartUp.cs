using System;

namespace ThreeupleGeneric
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInputInfo = Console.ReadLine().Split(" ", 4);
            string fullName = $"{firstInputInfo[0]} {firstInputInfo[1]}";
            string address = firstInputInfo[2];
            string town = firstInputInfo[3];

            string[] secondInputInfo = Console.ReadLine().Split();
            string name = secondInputInfo[0];
            int liters = int.Parse(secondInputInfo[1]);
            string state = secondInputInfo[2];
            string drinResult = state == "drunk" ? "True" : "False";

            string[] thirdInputInfo = Console.ReadLine().Split();
            string name1 = thirdInputInfo[0];
            double balance = double.Parse(thirdInputInfo[1]);
            string bankName = thirdInputInfo[2];

            Tuple<string, string, string> firstTuple = new Tuple<string, string, string>(fullName,address,town);
            Tuple<string, int, string> secondTuple = new Tuple<string, int, string>(name,liters,drinResult);
            Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(name1,balance,bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
