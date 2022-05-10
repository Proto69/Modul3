using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Freight
    {
        private string name;
        private double weight;

        public Freight(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name
        {
            get => name;
            set
            {
                CheckName(value);
                name = value;
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                CheckWeight(value);
                weight = value;
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public static void CheckName(string value)
        {
            if (value.Trim() == "" || value == null)
                throw new ArgumentException("Name cannot be empty");
        }

        public static void CheckWeight(double x)
        {
            if (x < 0)
                throw new ArgumentException("Weight cannot be negative");
        }
    }
}
