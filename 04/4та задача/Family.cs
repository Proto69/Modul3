using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Family
    {
        private List<Person> semeistwo = new List<Person>();
        public List<Person> Familly
        {
            get { return semeistwo; }
            set { semeistwo = value; }
        }

        public void AddMember(Person member)
        {
            Familly.Add(member);
        }

        public Person GetOldestMember()
        {
            Familly = Familly.OrderByDescending(x => x.Age).Take(1).ToList();
            Person oldest = Familly[0];
            return oldest;
        }
    }
}
