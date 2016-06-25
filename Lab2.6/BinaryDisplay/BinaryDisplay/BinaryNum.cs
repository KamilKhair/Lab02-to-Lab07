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
            var tempNum = _num;
            for (var i = 0; i < BinaryNumber.Length; ++i)
            {
                if ((tempNum & 1) == 1)
                {
                    ++numberOfOnes;
                }
                tempNum >>= 1;
            }
            return numberOfOnes;
        }
    }
}