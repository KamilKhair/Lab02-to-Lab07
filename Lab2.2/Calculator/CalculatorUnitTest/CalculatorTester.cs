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
        public void Test_Add_MaxValue_To_Maxvalue()
        {
            var c = new Calc();

            Assert.AreEqual(double.PositiveInfinity, c.Calcu(double.MaxValue, double.MaxValue, "+"));
        }

        [TestMethod]
        public void Test_Add_MinValue_To_MinValue()
        {
            var c = new Calc();

            Assert.AreEqual(double.NegativeInfinity, c.Calcu(double.MinValue, double.MinValue, "+"));
        }

        [TestMethod]
        public void Test_Add_MaxValue_To_Minvalue()
        {
            var c = new Calc();

            Assert.AreEqual(0.0, c.Calcu(double.MaxValue, double.MinValue, "+"));
        }

        [TestMethod]
        public void Test_Add_MaxValue_To_Small_Positive_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MaxValue, c.Calcu(200.0, double.MaxValue, "+"));
        }

        [TestMethod]
        public void Test_Add_MinValue_To_Small_Negative_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MinValue, c.Calcu(-200.0, double.MinValue, "+"));
        }

        [TestMethod]
        public void Test_Add_MaxValue_To_Small_Negative_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MaxValue - Math.Abs(-200.0), c.Calcu(-200.0, double.MaxValue, "+"));
        }

        [TestMethod]
        public void Test_Add_MinValue_To_Small_Positive_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MinValue + 200.0, c.Calcu(200.0, double.MinValue, "+"));
        }

        [TestMethod]
        public void Test_Sub()
        {
            var c = new Calc();
            Assert.AreEqual(0.0, c.Calcu(1, 1, "-"));
        }

        public void Test_Sub_Negative()
        {
            var c = new Calc();
            Assert.AreEqual(-30.0, c.Calcu(-10, 20, "-"));
            Assert.AreEqual(30.0, c.Calcu(20, -10, "-"));
            Assert.AreEqual(30.0, c.Calcu(10, -20, "-"));
            Assert.AreEqual(-30.0, c.Calcu(-20, 10, "-"));
            Assert.AreEqual(0.0, c.Calcu(-10, -10, "-"));
        }

        [TestMethod]
        public void Test_Sub_MaxValue_From_Maxvalue()
        {
            var c = new Calc();

            Assert.AreEqual(0.0, c.Calcu(double.MaxValue, double.MaxValue, "-"));
        }

        [TestMethod]
        public void Test_Sub_MinValue_From_MinValue()
        {
            var c = new Calc();

            Assert.AreEqual(0, c.Calcu(double.MinValue, double.MinValue, "-"));
        }

        [TestMethod]
        public void Test_Sub_MinValue_From_Maxvalue()
        {
            var c = new Calc();

            Assert.AreEqual(double.PositiveInfinity, c.Calcu(double.MaxValue, double.MinValue, "-"));
        }

        [TestMethod]
        public void Test_Sub_MaxValue_From_Minvalue()
        {
            var c = new Calc();

            Assert.AreEqual(double.NegativeInfinity, c.Calcu(double.MinValue, double.MaxValue, "-"));
        }

        [TestMethod]
        public void Test_Sub_MaxValue_From_Small_Positive_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MinValue - 200.0, c.Calcu(200.0, double.MaxValue, "-"));
        }

        [TestMethod]
        public void Test_Sub_MinValue_From_Small_Negative_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MaxValue -200.0, c.Calcu(-200.0, double.MinValue, "-"));
        }

        [TestMethod]
        public void Test_Sub_MaxValue_From_Small_Negative_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MinValue, c.Calcu(-200.0, double.MaxValue, "-"));
        }

        [TestMethod]
        public void Test_Sub_MinValue_From_Small_Positive_Number()
        {
            var c = new Calc();

            Assert.AreEqual(double.MinValue + 200.0, c.Calcu(200.0, double.MinValue, "+"));
        }

        [TestMethod]
        public void Test_Mul()
        {
            var c = new Calc();
            Assert.AreEqual(4.0, c.Calcu(2, 2, "*"));
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
        public void Test_Mull_MaxValue_By_Positive_Two()
        {
            var c = new Calc();
            Assert.AreEqual(double.PositiveInfinity, c.Calcu(double.MaxValue, 2.0, "*"));
        }

        [TestMethod]
        public void Test_Mull_MaxValue_By_Negative_Two()
        {
            var c = new Calc();
            Assert.AreEqual(double.NegativeInfinity, c.Calcu(double.MaxValue, -2.0, "*"));
        }

        [TestMethod]
        public void Test_Mull_MinValue_By_Positive_Two()
        {
            var c = new Calc();
            Assert.AreEqual(double.NegativeInfinity, c.Calcu(double.MinValue, 2.0, "*"));
        }

        [TestMethod]
        public void Test_Mull_MinValue_By_Negative_Two()
        {
            var c = new Calc();
            Assert.AreEqual(double.PositiveInfinity, c.Calcu(double.MinValue, -2.0, "*"));
        }

        [TestMethod]
        public void Test_Mull_MinValue_By_MaxValue()
        {
            var c = new Calc();
            Assert.AreEqual(double.NegativeInfinity, c.Calcu(double.MinValue, double.MaxValue, "*"));
        }

        [TestMethod]
        public void Test_Mull_MinValue_By_MinValue()
        {
            var c = new Calc();
            Assert.AreEqual(double.PositiveInfinity, c.Calcu(double.MinValue, double.MinValue, "*"));
        }

        [TestMethod]
        public void Test_Mull_MaxValue_By_MaxValue()
        {
            var c = new Calc();
            Assert.AreEqual(double.PositiveInfinity, c.Calcu(double.MaxValue, double.MaxValue, "*"));
        }

        [TestMethod]
        public void Test_Div()
        {
            var c = new Calc();
            Assert.AreEqual(2.0, c.Calcu(10, 5, "/"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Division by zero accured, And it is not allowed!")]
        public void Test_Div_Positive_By_Zero()
        {
            var c = new Calc();
            c.Calcu(10, 0, "/");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Division by zero accured, And it is not allowed!")]
        public void Test_Div_Negative_By_Zero()
        {
            var c = new Calc();
            c.Calcu(-10, 0, "/");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Division by zero accured, And it is not allowed!")]
        public void Test_Div_Zero_By_Zero()
        {
            var c = new Calc();
            c.Calcu(0, 0, "/");
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
    }
}
