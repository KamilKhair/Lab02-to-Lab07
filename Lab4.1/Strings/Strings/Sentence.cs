using System;

namespace Strings
{
    //Cool
    public class Sentence
    {
        private readonly string _sentense;

        public Sentence(string sentence)
        {
            _sentense = sentence;
        }

        //Consider a better name
        public string[] Arr { get; private set; }

        public void SplitSentence()
        {
            Arr = _sentense.Split();
        }

        public int NumberOfWords()
        {
            //Hmm, this sounds wrong. Maybe 0 is better
            //null == Arr ? 0 : Arr.Length;
            //Or see if return Arr?.Length; will work. "?." is the 'elvis-operator', check it out.
            if (Arr == null)
            {
                return -1;
            }
            return Arr.Length;
        }

        public void ReverseWords()
        {
            //You could have just added to the loop condition
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

        //Why didn't you throw an exception in the constructor if Arr was null, or something? 
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