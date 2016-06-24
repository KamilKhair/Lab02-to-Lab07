﻿namespace AccountsLib
{
    public class Account
    {
        internal Account(int id)
        {
            Id = id;
            Balance = 0;
        }

        public int Id { get; }

        public double Balance { get; private set; }

        public bool Deposit(double amount)
        {
            if (!(amount > 0)) return false;
            Balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (!(Balance > amount)) return false;
            Balance -= amount;
            return true;
        }

        public bool Transfer(Account distenationAcc, double amount)
        {
            if (!(Balance >= amount)) return false;
            distenationAcc.Balance += amount;
            Balance -= amount;
            return true;
        }
    }
}
