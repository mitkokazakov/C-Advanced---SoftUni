
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember

{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }

        public Person GetOldestPerson()
        {
            Person oldestMember = this.Members.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestMember;
            
        }
    }
}
