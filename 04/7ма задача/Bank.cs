using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bank
    {
        private int id;
        private double balance;

        public int ID { get => id; set => id = value; }
        public double Balance { get => balance; set => balance = value; }

        public void Deposit(double money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Please deposit positive amount of money!");
            }
            else Balance += money;
        }
        public void WithDraw(double money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Please withdraw positive amount of money!");
            }
            else if (money > Balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else balance -= money;
        }
        public override string ToString()
        {
            return $"Account ID{id}, balance {Balance:F2}";
        }
    }
}
