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
            string cmd;
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] input = cmd.Split(' ').ToArray();
                if (!dict.ContainsKey(input[0]))
                { 
                    dict.Add(input[0], new Person(input[0])); 
                }

                switch (input[1])
                {
                    case "company":
                        dict[input[0]].Company = new Company(input[2], input[3], double.Parse(input[4]));
                        break;
                    case "car":
                        dict[input[0]].Car = new Car(input[2], double.Parse(input[3]));
                        break;
                    case "pokemon":
                        dict[input[0]].Pokemons.Add(new Pokemon(input[2], input[3]));
                        break;
                    case "parents":
                        dict[input[0]].Parents.Add(new Parents(input[2], input[3]));
                        break;
                    case "children":
                        dict[input[0]].Children.Add(new Children(input[2], input[3]));
                        break;
                }
            }
            cmd = Console.ReadLine();
            Console.WriteLine(dict[cmd]);
        }
    }
}
