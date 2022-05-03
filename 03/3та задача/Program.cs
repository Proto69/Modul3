using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace List_of_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                Employee emp = new Employee();
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string work = input[2];
                string otdel = input[3];
                string email = "n/a";
                int age = -1;
                if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                }
                else if (input[input.Length - 1].Contains('@'))
                {
                    email = input[4];
                }
                else if (input.Length == 5)
                {
                    age = int.Parse(input[4]);
                }

                emp.FillEmployee(name, salary, work, otdel, email, age);
                if (!employees.ContainsKey(input[3]))
                {
                    employees.Add(input[3], new List<Employee>() { emp });
                }
                else employees[input[3]].Add(emp);
            }
            Dictionary<string, List<Employee>> dct = employees
                .OrderByDescending(x => x.Value.Average(y => y.Salary))
                .Take(1)
                .ToDictionary(e => e.Key, e => e.Value);

            Console.WriteLine($"Highest Average Salary: {dct.First().Key}");
            Console.WriteLine(String.Join("\n", dct.First().Value.OrderByDescending(x => x.Salary)));
        }
    }
}
