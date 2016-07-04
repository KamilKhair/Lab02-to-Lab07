using System.Collections.Generic;
using GenericApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiDictionaryTester
{
    [TestClass]
    public class MultiDictionaryUnitTest
    {
        [TestMethod]
        public void Test_Add_First_Key_To_Empty_Dictionary()
        {
            var dictionary = new MultiDictionary<int, string>();
            Assert.AreEqual(0,dictionary.Count);
            dictionary.Add(1, "one");
            Assert.AreEqual(true, dictionary.Contains(1, "one"));
            Assert.AreEqual(1, dictionary.Count);
        }

        [TestMethod]
        public void Test_Add_New_Key()
        {
            var dictionary = new MultiDictionary<int, string> {{1, "one"}, {2, "two"} };
            Assert.AreEqual(2, dictionary.Count);
            Assert.AreEqual(false, dictionary.ContainsKey(3));
            dictionary.Add(3, "sun");
            Assert.AreEqual(true, dictionary.ContainsKey(3));
            Assert.AreEqual(true, dictionary.Contains(3, "sun"));
            Assert.AreEqual(3, dictionary.Count);
        }

        [TestMethod]
        public void Test_Add_To_Existing_Key()
        {
            var dictionary = new MultiDictionary<int, string> {{1, "one"}, {2, "two"}};
            Assert.AreEqual(2, dictionary.Count);
            dictionary.Add(1, "ich");
            Assert.AreEqual(true, dictionary.Contains(1, "ich"));
            Assert.AreEqual(3, dictionary.Count);
        }

        [TestMethod]
        public void Test_Remove_Key_Failure_Empty_Dictionary()
        {
            var dictionary = new MultiDictionary<int, string>();
            Assert.AreEqual(false, dictionary.Remove(3));
        }

        [TestMethod]
        public void Test_Remove_Value_Failure_Empty_Dictionary()
        {
            var dictionary = new MultiDictionary<int, string>();
            Assert.AreEqual(false, dictionary.Remove(3, "sun"));
        }

        [TestMethod]
        public void Test_Remove_Key_Failure()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 2, "two" }, { 3, "three" } };
            Assert.AreEqual(false, dictionary.Remove(1));
            Assert.AreEqual(false, dictionary.Remove(4));
        }

        [TestMethod]
        public void Test_Remove_Value_Failure()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 2, "two" }, { 3, "three" } };
            Assert.AreEqual(false, dictionary.Remove(4, "sun"));
            Assert.AreEqual(false, dictionary.Remove(3, "two"));
            Assert.AreEqual(false, dictionary.Remove(1, "one"));
        }

        [TestMethod]
        public void Test_Remove_Last_Key()
        {
            var dictionary = new MultiDictionary<int, string> {{3, "sun"}};
            Assert.AreEqual(1, dictionary.Count);
            Assert.AreEqual(true, dictionary.Remove(3));
            Assert.AreEqual(0, dictionary.Count);
        }

        [TestMethod]
        public void Test_Remove_Last_Value()
        {
            var dictionary = new MultiDictionary<int, string> {{3, "sun"}};
            Assert.AreEqual(1, dictionary.Count);
            Assert.AreEqual(true, dictionary.Remove(3, "sun"));
            Assert.AreEqual(0, dictionary.Count);
            Assert.AreEqual(false, dictionary.ContainsKey(3));
        }

        [TestMethod]
        public void Test_Remove_Key()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 2, "two" }, { 3, "three" } };
            Assert.AreEqual(3, dictionary.Count);
            Assert.AreEqual(true, dictionary.Remove(3));
            Assert.AreEqual(1, dictionary.Count);
            Assert.AreEqual(false, dictionary.ContainsKey(3));
        }

        [TestMethod]
        public void Test_Remove_Value()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 2, "two" }, { 3, "three" } };
            Assert.AreEqual(3, dictionary.Count);
            Assert.AreEqual(true, dictionary.Remove(3, "sun"));
            Assert.AreEqual(2, dictionary.Count);
            Assert.AreEqual(true, dictionary.ContainsKey(3));
        }

        [TestMethod]
        public void Test_Clear_Dictionary()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 2, "two" }, { 3, "three" } };
            Assert.AreEqual(3, dictionary.Count);
            dictionary.Clear();
            Assert.AreEqual(0, dictionary.Count);
        }

        [TestMethod]
        public void Test_Clear_Empty_Dictionary()
        {
            var dictionary = new MultiDictionary<int, string>();
            Assert.AreEqual(0, dictionary.Count);
            dictionary.Clear();
            Assert.AreEqual(0, dictionary.Count);
        }

        [TestMethod]
        public void Test_Contains_Key()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 2, "two" }, { 3, "three" } };
            Assert.AreEqual(true, dictionary.ContainsKey(2));
        }

        [TestMethod]
        public void Test_Contains_Key_Failure()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 1, "two" }, { 3, "three" } };
            Assert.AreEqual(false, dictionary.ContainsKey(2));
        }

        [TestMethod]
        public void Test_Contains()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 2, "two" }, { 3, "three" } };
            Assert.AreEqual(true, dictionary.Contains(2, "two"));
        }

        [TestMethod]
        public void Test_Contains_Failure()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 1, "two" }, { 3, "three" } };
            Assert.AreEqual(false, dictionary.Contains(2, "two"));
            Assert.AreEqual(false, dictionary.Contains(1, "nee"));
            Assert.AreEqual(false, dictionary.Contains(4, "four"));
        }

        [TestMethod]
        public void Test_Keys_Property()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 1, "two" }, { 3, "three" } };
            var keysList = new List<int>();
            foreach (var key in dictionary.Keys)
            {
                keysList.Add(key);
            }
            Assert.AreEqual(2, keysList.Count);
            Assert.AreEqual(true, keysList.Contains(1));
            Assert.AreEqual(true, keysList.Contains(3));
            Assert.AreEqual(false, keysList.Contains(2));
        }

        [TestMethod]
        public void Test_Values_Property()
        {
            var dictionary = new MultiDictionary<int, string> { { 3, "sun" }, { 1, "two" }, { 3, "three" } };
            var keysList = new List<string>();
            foreach (var value in dictionary.Values)
            {
                keysList.Add(value);
            }
            Assert.AreEqual(3, keysList.Count);
            Assert.AreEqual(true, keysList.Contains("sun"));
            Assert.AreEqual(true, keysList.Contains("two"));
            Assert.AreEqual(true, keysList.Contains("three"));
            Assert.AreEqual(false, keysList.Contains("nee"));
        }
    }
}
