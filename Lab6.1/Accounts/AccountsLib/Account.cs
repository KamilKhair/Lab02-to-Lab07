﻿using System;

namespace AccountsLib
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

        public void Deposit(double amount)
        {
            //amount < 0
            if (!(amount > 0))
            {
                throw new ArgumentOutOfRangeException(null, "Hey! you can not deposit 0 or negative amount! ");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (!(Balance > amount))
            {
                throw new ArgumentOutOfRangeException(null ,"Hey! you can not go into overdraft! ");
            }
            Balance -= amount;
        }

        public void Transfer(Account destinationAcc, double amount)
        {
            var attempt = true;
            try
            {
                if (!(Balance >= amount) || amount < 0)
                {
                    attempt = false;
                    throw new ArgumentOutOfRangeException(null, "Illigal amount to transfer!");
                }
                destinationAcc.Balance += amount;
                Balance -= amount;
            }

            //Should be catchd in main
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //where is the try-finally and the logging with the *balance* before and after the operation is done?
                if (attempt)
                {
                    Console.WriteLine("Transfer has been attempt!");
                    Console.WriteLine("Account id = " + Id + " has a new balance = " + Balance);
                    Console.WriteLine("Account id = " + destinationAcc.Id + " has a new balance = " + destinationAcc.Balance);
                }
                else
                {
                    Console.WriteLine("Transfer has not been attempt!");
                }
            }
        }
    }
}
