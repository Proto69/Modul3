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
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            Dictionary<string, Product> dict2 = new Dictionary<string, Product>();

            string[] input = Console.ReadLine().Split('=', ';').Where(x => x != "").ToArray();
            for (int i = 1; i <= input.Length; i++)
            {
                try
                {
                    if (i % 2 != 0) dict.Add(input[i - 1], new Person(input[i - 1]));
                    else dict[input[i - 2]].Money = double.Parse(input[i - 1]);
                }
                catch (ArgumentException k) { Console.WriteLine(k.Message); }
            }
            input = Console.ReadLine().Split('=', ';').Where(x => x != "").ToArray();
            for (int i = 1; i <= input.Length; i++)
            {
                try
                {
                    if (i % 2 != 0) dict2.Add(input[i - 1], new Product(input[i - 1]));
                    else dict2[input[i - 2]].Price = double.Parse(input[i - 1]);
                }
                catch (ArgumentException k) { Console.WriteLine(k.Message); }
            }
            //изглежда зле ама ме мързи да го правя иначе
            while ((input = Console.ReadLine().Split(' ').ToArray())[0] != "END")
            {
                try
                {
                    if (dict.ContainsKey(input[0]) && dict2.ContainsKey(input[1]))
                    {
                        dict[input[0]].Buy(dict2[input[1]]);
                    }
                    else Console.WriteLine("Invalid arguments!");
                }
                catch (ArgumentException k) { Console.WriteLine(k.Message); }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
