using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Company
    {
        private string name;
        private string otdel;
        private double salary;

        public Company(string name, string otdel, double salary)
        {
            Name = name;
            Otdel = otdel;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} {Otdel} {Salary:F2}";
        }

        public string Name { get => name; set => name = value; }
        public string Otdel { get => otdel; set => otdel = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
