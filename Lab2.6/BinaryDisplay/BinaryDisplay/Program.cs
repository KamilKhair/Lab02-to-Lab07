using System;

namespace BinaryDisplay
{
    public class BinaryNum
    {
        public BinaryNum(int num)
        {
            _num = num;
        }

        int _num;

        public string BinaryNumber { get; private set; }

        public void ConvertToBinary()
        {
            BinaryNumber = Convert.ToString(_num, 2); // no boxing ! for more information read this article: https://selvasamuel.wordpress.com/2008/03/14/boxingunboxing-in-net/
        }

        public int NumberOfOnes()
        {
            if (BinaryNumber == "")
            {
                return 0;
            }
            var numberOfOnes = 0;
            for (var i = 0; i < BinaryNumber.Length; ++i)
            {
                if ((_num & 1) == 1)
                {
                    ++numberOfOnes;
                }
                _num >>= 1;
            }
            return numberOfOnes;
        }
    }
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
