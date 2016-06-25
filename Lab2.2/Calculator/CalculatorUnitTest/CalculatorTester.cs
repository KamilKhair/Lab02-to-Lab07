using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTester
    {
        [TestMethod]
        public void Test_Add()
        {
            var c = new Calc();
            Assert.AreEqual(2.0, c.Calcu(1, 1, "+"));
        }

        [TestMethod]
        public void Test_Sub()
        {
            var c = new Calc();
            Assert.AreEqual(0.0, c.Calcu(1, 1, "-"));
        }

        [TestMethod]
        public void Test_Mul()
        {
            var c = new Calc();
            Assert.AreEqual(4.0, c.Calcu(2, 2, "*"));
        }

        [TestMethod]
        public void Test_Div()
        {
            var c = new Calc();
            Assert.AreEqual(2.0, c.Calcu(10, 5, "/"));
        }

        [TestMethod]
        public void Test_Div_Positive_By_Zero()
        {
            var c = new Calc();
            Assert.AreEqual(double.PositiveInfinity, c.Calcu(10, 0, "/"));
        }

        [TestMethod]
        public void Test_Div_Negative_By_Zero()
        {
            var c = new Calc();
            Assert.AreEqual(double.NegativeInfinity, c.Calcu(-10, 0, "/"));
        }

        [TestMethod]
        public void Test_Add_Negative()
        {
            var c = new Calc();
            Assert.AreEqual(10.0, c.Calcu(-10, 20, "+"));
            Assert.AreEqual(10.0, c.Calcu(20, -10, "+"));
            Assert.AreEqual(-10.0, c.Calcu(10, -20, "+"));
            Assert.AreEqual(-10.0, c.Calcu(-20, 10, "+"));
            Assert.AreEqual(-20.0, c.Calcu(-10, -10, "+"));
        }

        [TestMethod]
        public void Test_Mull_Negative()
        {
            var c = new Calc();
            Assert.AreEqual(-200.0, c.Calcu(-10, 20, "*"));
            Assert.AreEqual(-200.0, c.Calcu(20, -10, "*"));
            Assert.AreEqual(-200.0, c.Calcu(10, -20, "*"));
            Assert.AreEqual(-200.0, c.Calcu(-20, 10, "*"));
            Assert.AreEqual(100.0, c.Calcu(-10, -10, "*"));
        }

        [TestMethod]
        public void Test_Div_Negative()
        {
            var c = new Calc();
            Assert.AreEqual(-0.5, c.Calcu(-10, 20, "/"));
            Assert.AreEqual(-2.0, c.Calcu(20, -10, "/"));
            Assert.AreEqual(-0.5, c.Calcu(10, -20, "/"));
            Assert.AreEqual(-2.0, c.Calcu(-20, 10, "/"));
            Assert.AreEqual(1.0, c.Calcu(-10, -10, "/"));
        }

        [TestMethod]
        public void Test_Incorrect_Operator()
        {
            var c = new Calc();
            Assert.AreEqual(double.NaN, c.Calcu(-20, 10, "\\"));
        }

        [TestMethod]
        public void Calc_Add_AddOverflow()
        {
            var c = new Calc();

            Assert.AreEqual(double.PositiveInfinity, c.Calcu(double.MaxValue, double.MaxValue, "+"));
        }

        [TestMethod]
        public void Calc_Add_Underflow()
        {
            var c = new Calc();

            Assert.AreEqual(double.NegativeInfinity, c.Calcu(double.MinValue, double.MinValue, "+"));
        }
    }
}
