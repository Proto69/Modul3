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
        private string code;
        private double quantity;
        private double price;

        public Product(string name, string code, double quantity, double price)
        {
            this.Name = name;
            this.Code = code;
            this.Quantity = quantity;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{name} ({code})";
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
    }
}
