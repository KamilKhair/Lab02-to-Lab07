using System;

namespace HelloPerson
{
    internal class HelloPerson
    {
        public static void Main()
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"hello {name}!");
            Console.WriteLine("Please enter an integer number in the range 1-10");
            int number;
            label1:
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Please enter only an integer number");
            }
            if (number > 10 || number < 1)
            {
                Console.WriteLine("Error: Please enter an integer number in the range 1-10");
                goto label1;
            }
            Console.WriteLine(name);
            for (var i = 0; i < number - 1; ++i)
            {
                Console.WriteLine($"{AddSpaces(i)} {name}");
            }
        }

        private static string AddSpaces(int i)
        {
            var spaces = "";
            for (var j = 0; j < i; ++j)
            {
                spaces += " ";
            }
            return spaces;
        }
    }
}
