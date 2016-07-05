using System;
using AccountsLib;

namespace Bank
{
    internal class Program
    {
        internal static void Main()
        {
            Console.WriteLine("Let's create our first account! Please enter Account ID:");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Error: Wrong Input");
                return;
            }
            Console.WriteLine("Please enter initial balance:");
            double balance;
            if (!double.TryParse(Console.ReadLine(), out balance))
            {
                Console.WriteLine("Error: Wrong Input");
                return;
            }
            if (balance <= 0)
            {
                Console.WriteLine("Error: Balance has to be positive");
                return;
            }
            var acc = AccountFactory.CreateAccount(id, balance);
            Console.WriteLine($"Account id = {id} successfully created!");

            Console.WriteLine("Let's Deposit some money to our account!, please enter amount:");
            double deposit;
            if (!double.TryParse(Console.ReadLine(), out deposit))
            {
                Console.WriteLine("Error: Wrong Input");
                return;
            }
            if (acc.Deposit(deposit))
            {
                Console.WriteLine($"Account id = {id} has a new balance = {acc.Balance}");
            }
            else
            {
                Console.WriteLine("Hey! you can not deposit 0 or negative amount! ");
                return;
            }

            Console.WriteLine("Let's Withdraw some money from our account!, please enter amount:");
            double withdraw;
            if (!double.TryParse(Console.ReadLine(), out withdraw))
            {
                Console.WriteLine("Error: Wrong Input");
                return;
            }
            if (withdraw <= 0)
            {
                Console.WriteLine("Hey! you can not withdraw 0 or negative amount! ");
                return;
            }
            if (acc.Withdraw(withdraw))
            {
                Console.WriteLine($"Account id = {id} has a new balance = {acc.Balance}");
            }
            else
            {
                Console.WriteLine("Hey! you can not go into overdraft! ");
                return;
            }

            Console.WriteLine("Let's creat our second account! Please enter Account ID:");
            int id2;
            if (!int.TryParse(Console.ReadLine(), out id2))
            {
                Console.WriteLine("Error: Wrong Input");
                return;
            }
            if (id2 == id)
            {
                Console.WriteLine("Error, you can not create an account with the same id !");
                return;
            }
            Console.WriteLine("Please enter initial balance:");
            double balance2;
            if (!double.TryParse(Console.ReadLine(), out balance2))
            {
                Console.WriteLine("Error: Wrong Input");
                return;
            }
            if (balance2 <= 0)
            {
                Console.WriteLine("Error: Balance has to be positive");
                return;
            }
            var acc2 = AccountFactory.CreateAccount(id2, balance2);
            Console.WriteLine($"Account id = {id2} successfully created!");

            Console.WriteLine("Let's Transfer some money from our first accout to second account, please enter amount:");
            double amount;
            if (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Error: Wrong Input");
                return;
            }
            if (acc.Transfer(acc2, amount))
            {
                Console.WriteLine($"Account id = {id2} has a new balance = {acc2.Balance}");
                Console.WriteLine($"Account id = {id} has a new balance = {acc.Balance}");
            }
            else
            {
                Console.WriteLine("Error: wrong amount to transfer");
                return;
            }

            Console.WriteLine("Thank you very much ! See you later :)");
        }
    }
}
