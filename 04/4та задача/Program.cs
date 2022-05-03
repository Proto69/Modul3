using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                string[] input = Console.ReadLine().Split(' ').ToArray();
                person.Name = input[0];
                person.Age = int.Parse(input[1]);
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember());
        }
    }
}