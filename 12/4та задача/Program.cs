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
            //тая задача е с много грешно условие
            Dictionary<string, Product> shop = new Dictionary<string, Product>();
            string[] input;
            while ((input = Console.ReadLine().Split(' ').ToArray())[0] != "Close")
            {
                switch (input[0])
                {
                    case "Add":
                        Shop.Add(input[1], input[2], double.Parse(input[3]), double.Parse(input[4]), shop);
                        break;
                    case "Sell":
                        Shop.Sell(input[1], double.Parse(input[2]), shop);
                        break;
                    case "Update":
                        Shop.Update(input[1], double.Parse(input[2]), shop);
                        break;
                    case "PrintA":
                        Shop.PrintA(shop);
                        break;
                    case "PrintD":
                        Shop.PrintD(shop);
                        break;
                    case "Calculate":
                        Shop.Calculate(shop);
                        break;
                }
            }
        }
    }
}
