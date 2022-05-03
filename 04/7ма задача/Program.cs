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
            Dictionary<int, Bank> dict = new Dictionary<int, Bank>();
            string input;
            while ((input = Console.ReadLine()).ToLower() != "end")
            {
                string[] cmdArgs = input.Split(" ").ToArray();
                switch (cmdArgs[0].ToLower())
                {
                    case "create":
                        CreateAcc(int.Parse(cmdArgs[1]), dict);
                        break;
                    case "deposit":
                        Deposit(int.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]), dict);
                        break;
                    case "withdraw":
                        WithDraw(int.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]), dict);
                        break;
                    case "print":
                        Console.WriteLine(dict[int.Parse(cmdArgs[1])]);
                        break;
                }
            }
        }

        private static void WithDraw(int id, double amount, Dictionary<int, Bank> dict)
        {
            if (CheckForID(id, dict))
            {
                dict[id].WithDraw(amount);
            }
            else Console.WriteLine($"Account with ID{id} doesn't exists!");
        }

        private static void Deposit(int id, double amount, Dictionary<int, Bank> dict)
        {
            if (CheckForID(id, dict))
            {
                dict[id].Deposit(amount);
            }
            else Console.WriteLine($"Account with ID{id} doesn't exists!");
        }

        static bool CheckForID(int id, Dictionary<int, Bank> dict)
        {
            if (dict.ContainsKey(id))
            {
                return true;
            }
            else return false;
        }
        static void CreateAcc(int id, Dictionary<int, Bank> dict)
        {
            if (CheckForID(id, dict))
            {
                Console.WriteLine("Account already exist");
            }
            else
            {
                Bank acc = new Bank();
                acc.ID = id;
                dict.Add(id, acc);
            }
        }
    }
}