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
            while (n-- > 0)
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(MyMath.GetSquare(a));
            }
        }
    }
}
