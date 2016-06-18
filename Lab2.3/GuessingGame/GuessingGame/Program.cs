using System;
using static System.Console;

namespace GuessingGame
{
    internal class Program
    {
        internal static void Main()
        {
            var secret = new Random().Next(1, 100);
            WriteLine("Welcome to the Guess Game !");
            WriteLine("I have a number in the range 1-100, Please enter a number and try to guess it!");
            var rounds = 0;
            int number;
            while (!int.TryParse(ReadLine(), out number))
            {
                Console.WriteLine("Error: Please insert a correct integer number:");
            }
            while (rounds < 7 && number != secret)
            {
                WriteLine(number > secret ? "Too big, try again!" : "Too small, try again!");
                while (!int.TryParse(ReadLine(), out number))
                {
                    Console.WriteLine("Error: Please insert a correct integer number:");
                }
                ++rounds;
            }
            if (rounds == 7)
            {
                WriteLine("You Failed to guess the number in 7 rounds! the number is " + secret);
            }
            else
            {
                WriteLine("Good job! you guesed the number " + secret + " in " + (rounds + 1) + " rounds!");
            }
        }
    }
}
