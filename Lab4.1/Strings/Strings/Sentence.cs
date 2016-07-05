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
}