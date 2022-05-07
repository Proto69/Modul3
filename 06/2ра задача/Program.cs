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
            Dictionary<string, Rectangle> dict = new Dictionary<string, Rectangle>();
            int[] lines = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < lines[0]; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4])));
                }
            }
            for (int i = 0; i < lines[1]; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ').ToArray();
                if (dict.ContainsKey(cmd[0]) && dict.ContainsKey(cmd[1]))
                {

                    Console.WriteLine(Check(dict[cmd[0]], dict[cmd[1]]));
                }
            }
        }

        static string Check(Rectangle rect1, Rectangle rect2)
        {
            string check = "true";

            if (rect1.Y2 >= rect2.Y1 || rect2.Y2 >= rect1.Y1)
            {
                check = "false";
            }
            if (rect1.X2 >= rect2.X1 || rect2.X2 >= rect1.X1)
            {
                check = "false";
            }

            return check;
        }
    }
}