using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int id, double balance) : this(id)
        {
            this.Balance = balance;
        }

        public BankAccount(int id)
        {
            this.Id = id;
        }

        public void Deposit(double money)
        {
            if (money < 0)
                throw new ArgumentException("The amount of money should be positive!");
            Balance += money;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance || amount <= 0)
                throw new ArgumentException("Invalid amount of money!");
            Balance -= amount;
        }

        public int Id { get => id; set => id = value; }
        public double Balance { get => balance; set => balance = value; }
    }
}
