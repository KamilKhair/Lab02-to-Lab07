using BinaryDisplay;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDisplayUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ConvertToBinary_Positive()
        {
            var binary = new BinaryNum(5); 
            binary.ConvertToBinary();
            Assert.AreEqual("101", binary.BinaryNumber);
        }

        [TestMethod]
        public void Test_ConvertToBinary_Negative()
        {
            var binary = new BinaryNum(-5);
            binary.ConvertToBinary();
            Assert.AreEqual("11111111111111111111111111111011", binary.BinaryNumber);
        }

        [TestMethod]
        public void Test_NumberOfOnes_Negative()
        {
            var binary = new BinaryNum(-5);
            binary.ConvertToBinary();
            Assert.AreEqual(31, binary.NumberOfOnes());
        }

        [TestMethod]
        public void Test_NumberOfOnes_Positive()
        {
            var binary = new BinaryNum(5);
            binary.ConvertToBinary();
            Assert.AreEqual(2, binary.NumberOfOnes());
        }
    }
}
