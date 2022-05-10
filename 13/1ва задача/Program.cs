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
            //примерите са грешни :)))
            Dictionary<string, Truck> trucks = new Dictionary<string, Truck>();
            Dictionary<string, Freight> freights = new Dictionary<string, Freight>();

            List<string> input = Console.ReadLine().Split('=', ';').Where(x => x != "").ToList();
            
            while (input.Count != 0)
            {
                try
                {
                    trucks.Add(input[0], new Truck(input[0], double.Parse(input[1])));
                }
                catch (ArgumentException k) { Console.WriteLine(k.Message); }
                input.RemoveRange(0, 2);
            }

            input = Console.ReadLine().Split('=', ';').Where(x => x != null && x != "").ToList();

            while (input.Count != 0)
            {
                try
                {
                    freights.Add(input[0], new Freight(input[0], double.Parse(input[1])));
                }
                catch (ArgumentException k) { Console.WriteLine(k.Message); }
                input.RemoveRange(0, 2);
            }

            while ((input = Console.ReadLine().Split(' ').ToList())[0] != "END")
            {
                try
                {
                    if (!trucks.ContainsKey(input[0]))
                        throw new ArgumentException("This truck doesn't exist");
                    trucks[input[0]].LoadTruck(freights[input[1]]);
                }
                catch (ArgumentException k) { Console.WriteLine(k.Message); }
            }
            foreach (var item in trucks)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
