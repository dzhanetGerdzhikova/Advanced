using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> PeopleInFamily { get; set; }

        public Family()
        {
            this.PeopleInFamily = new List<Person>();
        }

        public void AddMember(Person member)
        {
            PeopleInFamily.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = PeopleInFamily.Max(e => e.Age);
            Person oldest = PeopleInFamily.FirstOrDefault(e => e.Age == maxAge);
            return oldest;
        }

        public List<Person> SortAgeMoreThan30()
        {
            return PeopleInFamily.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }
    }
}