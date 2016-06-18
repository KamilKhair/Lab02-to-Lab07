using System;

namespace Strings
{
    public class Sentence
    {
        private readonly string _sentense;

        public Sentence(string sentence)
        {
            _sentense = sentence;
        }

        public string[] Arr { get; private set; }

        public void SplitSentence()
        {
            Arr = _sentense.Split();
        }

        public int NumberOfWords()
        {
            if (Arr == null)
            {
                return -1;
            }
            return Arr.Length;
        }

        public void ReverseWords()
        {
            if (Arr == null)
            {
                return;
            }
            for (var i = 0; i < Arr.Length; ++i)
            {
                var charArray = Arr[i].ToCharArray();
                Array.Reverse(charArray);
                Arr[i] = new string(charArray);
            }
        }

        public void SortSentence()
        {
            if (Arr == null)
            {
                return;
            }
            Array.Sort(Arr);
        }
    }
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please insert a sentence of words: (insert empty string to exit)");
            var s = Console.ReadLine();
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
