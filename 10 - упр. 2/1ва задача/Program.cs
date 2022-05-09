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
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string name = input[1];
            int n = int.Parse(input[2]);
            try
            {
                if (n > 10 || n < 0) throw new ArgumentException("Number of toppings should be in range [0..10].");

            input = Console.ReadLine().Split(' ').ToArray();
            
                Pizza pizza = new Pizza(name, new Dough(input[1], input[2], double.Parse(input[3])));

                for (int i = 0; i < n; i++)
                {
                    input = Console.ReadLine().Split(' ').ToArray();
                    pizza.AddTopping(new Topping(input[1], double.Parse(input[2])));
                }
                Console.ReadLine();
                Console.WriteLine(pizza);
            }
            catch (ArgumentException k) { Console.WriteLine(k.Message); }
        }
    }
}
