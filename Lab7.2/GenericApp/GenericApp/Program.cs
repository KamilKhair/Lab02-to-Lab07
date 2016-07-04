﻿using System;

namespace GenericApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };

            Console.WriteLine("Initial state:");
            DisplayDictionary(dictionary);

            Console.WriteLine("After Removing key = 3, value = sun:");
            dictionary.Remove(3, "sun");
            DisplayDictionary(dictionary);

            Console.WriteLine("After Removing key = 3:");
            dictionary.Remove(3);
            DisplayDictionary(dictionary);

            Console.WriteLine("After Removing key = 1:");
            dictionary.Remove(1);
            DisplayDictionary(dictionary);

            Console.WriteLine("Returning to Initial state:");
            dictionary.Add(1, "one");
            dictionary.Add(1, "ich");
            dictionary.Add(3, "three");
            dictionary.Add(3, "sun");
            DisplayDictionary(dictionary);

            Console.WriteLine("After Clearing the dictionary:");
            dictionary.Clear();
            DisplayDictionary(dictionary);

            Console.WriteLine("Returning to Initial state:");
            dictionary.Add(1, "one");
            dictionary.Add(1, "ich");
            dictionary.Add(2, "two");
            dictionary.Add(2, "nee");
            dictionary.Add(3, "three");
            dictionary.Add(3, "sun");
            DisplayDictionary(dictionary);

            Console.WriteLine("The values are:");
            foreach (var value in dictionary.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            Console.WriteLine("The Keys are:");
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();
            Console.WriteLine(dictionary.Contains(1, "one")
                ? "The Multi Dictionary contains key = 1, value = one"
                : "The Multi Dictionary does not contain key = 1, value = one");

            Console.WriteLine(dictionary.ContainsKey(3)
                ? "The Multi Dictionary contains key = 3"
                : "The Multi Dictionary does not contain key = 3");
        }

        private static void DisplayDictionary<TKey, TValue>(MultiDictionary<TKey, TValue> dictionary)
        {
            foreach (var key in dictionary)
            {
                foreach (var value in key.Value)
                {
                    Console.WriteLine($"Key = {key.Key}, Value = {value}");
                }
            }
            Console.WriteLine($"Count = {dictionary.Count}");
            Console.WriteLine();
        }
    }
}
