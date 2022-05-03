using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class People
    {
        private List<Person> people = new List<Person>();
        public List<Person> Humans
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            Humans.Add(member);
        }

        public void GetResult()
        {
            Humans = Humans.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            foreach (var human in Humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
