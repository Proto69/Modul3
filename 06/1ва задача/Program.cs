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
            Dictionary<string, Car> dict = new Dictionary<string, Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
                }
            }
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd.Split(' ').ToArray();
                if (cmdArgs[0] == "Drive") dict[cmdArgs[1]].Drive(double.Parse(cmdArgs[2]));
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}