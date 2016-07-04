using System;

namespace GenericApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new MultiDictionary<int, string>();

            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(1, "ich");
            dictionary.Add(2, "nee");
            dictionary.Add(3, "sun");


            foreach (var key in dictionary)
            {
                foreach (var value in key.Value)
                {
                    Console.WriteLine($"Key = {key.Key}, Value = {value}");
                }
            }
        } 
    }
}
