using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Baza
{
    internal class BankAccount
    {
        private string owner;
        private float balance;
        private float balanceRate;

        public BankAccount(string owner, float balance, float balanceRate)
        {
            this.owner = owner;
            this.balance = balance;
            if (balanceRate < 0)
            {
                this.balanceRate = 0;
            }
            else
            {
                this.balanceRate = balanceRate;
            }
        }

        public string Owner { get => owner; }
        public float Balance { get => balance; }
        public float BalanceRate { get => balanceRate;

            protected set {
                if (this.balanceRate < 0) {
                    this.balanceRate = 0;
                }
                this.balanceRate = value;
            } 
        }
        public void Deposite(float value) {
            if (value < 0) {
                Console.WriteLine("Введён неверный баланс!");
            }
            else
            {
                this.balance += value;
                Console.WriteLine("Счёт успешно пополнен!");
            }
        }
        public void WithDraw(float value) {
            if (value <= this.Balance) {
                this.balance -= value;
                Console.WriteLine("Деньги" +
                    " успешно сняты!");
            }
        }

        public void AddRate(float value) {
            if (value >= 0)
            {
                this.balanceRate += value;
            }
        }
    }
}
