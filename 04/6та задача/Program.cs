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
            string input = Console.ReadLine();
            DateModifier date = new DateModifier();
            date.Date1 = DateTime.ParseExact(input, "yyyy MM dd", null);
            input = Console.ReadLine();
            date.Date2 = DateTime.ParseExact(input, "yyyy MM dd", null);
            date.FindDays();
        }
    }
}