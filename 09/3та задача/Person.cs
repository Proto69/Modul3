using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private double money;
        private List<Product> products = new List<Product>();

        public Person(string name)
        {
            this.name = name;
        }

        public void Buy(Product product)
        {
            if (product.Price > Money)
                throw new ArgumentException($"{Name} can't afford {product.Name}");
            Money -= product.Price;
            Products.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }

        public override string ToString()
        {
            return $"{Name} - {string.Join(", ", Products)}";
        }

        internal List<Product> Products { get => products; set => products = value; }

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

        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The amount of money should be a positive number!");
                money = value;
            }
        }
    }
}
