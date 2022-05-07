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
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Motor> dict = new Dictionary<string, Motor>();
            Dictionary<string, Car> dict2 = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string displacement = "n/a";
                string eff = "n/a";
                if (input.Length == 3 && input[2].All(char.IsNumber))
                {
                    displacement = input[2];
                }
                else if (input.Length == 3) eff = input[2];
                else if (input.Length == 4)
                {
                    displacement = input[2];
                    eff = input[3];
                }
                Motor motor = new Motor(input[0], double.Parse(input[1]), displacement, eff);
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], motor);
                }
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string weight = "n/a";
                string color = "n/a";
                if (input.Length == 3 && input[2].All(char.IsNumber))
                {
                    weight = input[2];
                }
                else if (input.Length == 3) color = input[2];
                else if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                }
                if (!dict2.ContainsKey(input[0]))
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        dict2.Add(input[0], new Car(input[0], dict[input[1]], weight, color));
                    }
                }
            }

            foreach (var item in dict2)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}