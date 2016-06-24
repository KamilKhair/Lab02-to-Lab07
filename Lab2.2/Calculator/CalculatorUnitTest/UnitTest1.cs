using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(2.0, c.Calc(1, 1, "+"));
        }

        [TestMethod]
        public void TestSub()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(0.0, c.Calc(1, 1, "-"));
        }

        [TestMethod]
        public void TestMul()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(4.0, c.Calc(2, 2, "*"));
        }

        [TestMethod]
        public void TestDiv()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(2.0, c.Calc(10, 5, "/"));
        }

        [TestMethod]
        public void TestDivPositiveByZero()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(double.PositiveInfinity, c.Calc(10, 0, "/"));
        }

        [TestMethod]
        public void TestDivNegativeByZero()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(double.NegativeInfinity, c.Calc(-10, 0, "/"));
        }

        [TestMethod]
        public void TestAddNegative()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(10.0, c.Calc(-10, 20, "+"));
            Assert.AreEqual(10.0, c.Calc(20, -10, "+"));
            Assert.AreEqual(-10.0, c.Calc(10, -20, "+"));
            Assert.AreEqual(-10.0, c.Calc(-20, 10, "+"));
            Assert.AreEqual(-20.0, c.Calc(-10, -10, "+"));
        }

        [TestMethod]
        public void TestMullNegative()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(-200.0, c.Calc(-10, 20, "*"));
            Assert.AreEqual(-200.0, c.Calc(20, -10, "*"));
            Assert.AreEqual(-200.0, c.Calc(10, -20, "*"));
            Assert.AreEqual(-200.0, c.Calc(-20, 10, "*"));
            Assert.AreEqual(100.0, c.Calc(-10, -10, "*"));
        }

        [TestMethod]
        public void TestDivNegative()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(-0.5, c.Calc(-10, 20, "/"));
            Assert.AreEqual(-2.0, c.Calc(20, -10, "/"));
            Assert.AreEqual(-0.5, c.Calc(10, -20, "/"));
            Assert.AreEqual(-2.0, c.Calc(-20, 10, "/"));
            Assert.AreEqual(1.0, c.Calc(-10, -10, "/"));
        }

        [TestMethod]
        public void TestIncorrectOperator()
        {
            var c = new Calculator.Calculator();
            Assert.AreEqual(Math.PI, c.Calc(-20, 10, "\\"));
        }
    }
}
