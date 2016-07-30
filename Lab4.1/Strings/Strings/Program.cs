using System;

namespace Strings
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please insert a sentence of words: (insert empty string to exit)");
            var s = Console.ReadLine();

            //string.IsNullOrEmpty is better
            while (s != "")
            {
                if (s != null)
                {
                    var sentence = new Sentence(s);
                    sentence.SplitSentence();
                    Console.WriteLine("Number of words is: " + sentence.NumberOfWords());
                    Console.WriteLine();
                    sentence.ReverseWords();
                    Console.WriteLine("After Reversing the words:");

                    foreach (var t in sentence.Arr)
                    {
                        //Console.Write("{0} ", t);
                        //Console.Write($"{t} ");
                        //Console.Write(string.Format("{0} ", t));
                        //All of the above are better than string cancatenation
                        Console.Write(t + " ");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    sentence.SortSentence();

                    Console.WriteLine("After Sorting the array:");
                    foreach (var t in sentence.Arr)
                    {
                        Console.Write(t + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Please insert a sentence of words: (insert empty string to exit)");
                s = Console.ReadLine();
            }
        }
    }
}
