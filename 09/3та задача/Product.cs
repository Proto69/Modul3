using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        private string name;
        private double price;

        public Product(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                    throw new ArgumentException("The name shouldn't be empty string!");
                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The amount of money should be a positive number!");
                price = value;
            }
        }
    }
}
