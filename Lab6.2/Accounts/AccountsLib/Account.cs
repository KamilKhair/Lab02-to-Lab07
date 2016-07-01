using System;

namespace AccountsLib
{

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string message)
        : base(message)
        {
        }
    }

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
            if (!(amount > 0))
            {
                throw new ArgumentOutOfRangeException(null, "Hey! you can not deposit 0 or negative amount! ");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (!(Balance > amount) || amount <= 0)
            {
                throw new InsufficientFundsException("Hey! you can not go into overdraft! ");
            }
            Balance -= amount;
        }

        public void Transfer(Account distenationAcc, double amount)
        {
            var attempt = true;
            try
            {
                if (!(Balance >= amount) || amount <= 0)
                {
                    attempt = false;
                    throw new ArgumentOutOfRangeException(null, "Illigal amount to transfer!");
                }
                distenationAcc.Balance += amount;
                Balance -= amount;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (attempt)
                {
                    Console.WriteLine("Transfer has been attempt!");
                    Console.WriteLine("Account id = " + Id + " has a new balance = " + Balance);
                    Console.WriteLine("Account id = " + distenationAcc.Id + " has a new balance = " + distenationAcc.Balance);
                }
                else
                {
                    Console.WriteLine("Transfer has not been attempt!");
                }
            }
        }
    }
}
