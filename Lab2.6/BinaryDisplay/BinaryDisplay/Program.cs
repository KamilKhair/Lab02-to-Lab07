using System;

namespace BinaryDisplay
{
    public class Program
    {
        public static void Main()
        {
            //2.6.2
            Console.WriteLine("Please enter an integer number ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Please enter an integer number ");
            }

            BinaryNum number = new BinaryNum(num);
            number.ConvertToBinary();
            Console.WriteLine($"Binary representation of {num} is {number.BinaryNumber}");

            //2.6.3
            Console.WriteLine($"There are {number.NumberOfOnes()} \"1\"s");
        }
    }
}
