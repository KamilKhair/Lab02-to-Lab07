using System;

namespace HelloPerson
{
    internal class HelloPerson
    {
        public static void Main()
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            //You used a C# 6 feature. Nice!
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

                //Oh no you didn't...goto is disliked and not recommended to use in such cases.
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

            //There are better way to add spaces. String cancatenatin isn't the best or effective way.
            //Consider using a string format with a format modifier, a string constructor that accepts a duplication argument or even a StringBuilder
            var spaces = "";
            for (var j = 0; j < i; ++j)
            {
                spaces += " ";
            }
            return spaces;
        }
    }
}
