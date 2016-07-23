using System;

namespace GuessingGame
{
    //Nice Job.
    internal class Program
    {
        internal static void Main()
        {
            var secret = new Random().Next(1, 101);
            Console.WriteLine("Welcome to the Guess My Number Game !");
            Console.WriteLine("I have a number in the range 1-100, Please enter a number and try to guess it!");
            var rounds = 0;
            var number = 0;
            var gameStarted = false;
            while (rounds < 7 && number != secret)
            {
                if (gameStarted)
                {
                    Console.WriteLine(number > secret ? "Too big, try again!" : "Too small, try again!");
                }
                label1:
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Error: Please insert a correct integer number:");
                }
                if (number < 1 || number > 100)
                {
                    Console.WriteLine("Error: Please insert a number in the range 1-100:");

                    //You shold avoid goto statements.3
                    goto label1;
                }
                if (!gameStarted)
                {
                    gameStarted = true;
                }
                ++rounds;
            }
            Console.WriteLine(rounds == 7 && number != secret
                ? $"You Failed to guess the number in 7 rounds! the number is {secret}"
                : $"Good job! you guesed the number {secret} in {rounds} rounds!");
        }
    }
}
