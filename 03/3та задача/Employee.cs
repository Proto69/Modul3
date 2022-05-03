using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_employees
{
    class Employee
    {
        private string name;
        private double salary;
        private string work;
        private string otdel;
        private string email = "n/a";
        private int age = -1;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        public string Otdel
        {
            get { return otdel; }
            set { otdel = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void FillEmployee(string name, double salary, string work, string otdel, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.work = work;
            this.otdel = otdel;
            this.email = email;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{name} {salary:F2} {email} {age}";
        }
    }
}
