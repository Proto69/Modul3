using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Shop
    {
        public static void Sell(string code, double quantity, Dictionary<string, Product> dict)
        {
            try
            {
                if (!dict.ContainsKey(code))
                    throw new ArgumentException("Not enough quantity");
                if (dict[code].Quantity < quantity)
                    throw new ArgumentException("Not enough quantity");
                dict[code].Quantity -= quantity;
            }
            catch (ArgumentException k) { Console.WriteLine(k.Message); }
        }
        public static void Add(string code, string name, double price, double quantity, Dictionary<string, Product> dict)
        {
            try
            {
                if (dict.ContainsKey(code))
                    throw new ArgumentException("This item already exists");
                Product x = new Product(name, code, quantity, price);
                dict.Add(code, x);
            }
            catch (ArgumentException k) { Console.WriteLine(k.Message); }
        }
        public static void Update(string code, double quantity, Dictionary<string, Product> dict)
        {
            try
            {
                if (!dict.ContainsKey(code))
                    throw new ArgumentException("Please add your product first!");
                dict[code].Quantity += quantity; 
            }
            catch (ArgumentException k) { Console.WriteLine(k.Message); }
        }
        public static void PrintA(Dictionary<string, Product> dict)
        {
            foreach (var item in dict.OrderBy(x => x.Value.Name))
            {
                Console.WriteLine(item.Value);
            }
        }
        public static void PrintD(Dictionary<string, Product> dict)
        {
            foreach (var item in dict.OrderByDescending(x => x.Value.Quantity))
            {
                Console.WriteLine(item.Value);
            }
        }
        public static void Calculate(Dictionary<string, Product> dict)
        {
            double sum = 0;
            foreach (var item in dict)
            {
                sum += item.Value.Quantity * item.Value.Price;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
