using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Bank
    {
        public static void Deposit(int id, double money, Dictionary<int, BankAccount> dict)
        {
            CheckForAccount(id, dict);
            dict[id].Deposit(money);
        }
        public static void Withdraw(int id, double money,, Dictionary<int, BankAccount> dict)
        {
            CheckForAccount(id, dict);
            dict[id].Withdraw(money);
        }
        private static void CheckForAccount(int id, Dictionary<int, BankAccount> dict)
        {
            if (!dict.ContainsKey(id))
                throw new ArgumentException("This account doesn't exists!");
        }
    }
}
