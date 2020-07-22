using System;

namespace OldestFamilyMember
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                
                family.AddMember(person);
            }

            
            Console.WriteLine(family.GetOldestPerson());
        }
    }
}
