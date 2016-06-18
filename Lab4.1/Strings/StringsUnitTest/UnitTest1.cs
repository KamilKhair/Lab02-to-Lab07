using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SplitSentence()
        {
            var sentence = new Sentence("Hello C#!");
            sentence.SplitSentence();
            Assert.AreEqual(2, sentence.Arr.Length);
            Assert.AreEqual("Hello", sentence.Arr[0]);
            Assert.AreEqual("C#!", sentence.Arr[1]);
        }

        [TestMethod]
        public void Test_NumberOfWords()
        {
            var sentence = new Sentence("Hello C#!");
            sentence.SplitSentence();
            Assert.AreEqual(2, sentence.NumberOfWords());
        }

        [TestMethod]
        public void Test_NumberOfWords_Without_Splitting()
        {
            var sentence = new Sentence("Hello C#!");
            Assert.AreEqual(-1, sentence.NumberOfWords());
        }

        [TestMethod]
        public void Test_ReverseWords()
        {
            var sentence = new Sentence("Hello C#!");
            sentence.SplitSentence();
            sentence.ReverseWords();
            Assert.AreEqual("olleH", sentence.Arr[0]);
            Assert.AreEqual("!#C", sentence.Arr[1]);
        }

        [TestMethod]
        public void Test_ReverseWords_Without_Splitting()
        {
            var sentence = new Sentence("Hello C#!");
            sentence.ReverseWords();
            Assert.AreEqual(null, sentence.Arr);
        }

        [TestMethod]
        public void Test_SortSentence()
        {
            var sentence = new Sentence("Hello C#!");
            sentence.SplitSentence();
            Assert.AreEqual("Hello", sentence.Arr[0]);
            Assert.AreEqual("C#!", sentence.Arr[1]);
            sentence.SortSentence();
            Assert.AreEqual("C#!", sentence.Arr[0]);
            Assert.AreEqual("Hello", sentence.Arr[1]);
        }

        [TestMethod]
        public void Test_SortSentence_Without_Splitting()
        {
            var sentence = new Sentence("Hello C#!");
            sentence.SortSentence();
            Assert.AreEqual(null, sentence.Arr);
        }
    }
}
