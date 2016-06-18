using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace QuadUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Two_Solutions()
        {
            const double a = 1;
            const double b = 5;
            const double c = 3;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(-0.6972243622680054, q.X1);
            Assert.AreEqual(-4.302775637731995, q.X2);
        }

        [TestMethod]
        public void Test_One_Solution_A_NotEqual_To_Zero()
        {
            const double a = 1;
            const double b = 4;
            const double c = 4;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(-2.0, q.X1);
            Assert.AreEqual(double.NaN, q.X2);
        }

        [TestMethod]
        public void Test_One_Solution_A_Equal_To_Zero()
        {
            const double a = 0;
            const double b = 4;
            const double c = 4;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(-1.0, q.X1);
            Assert.AreEqual(double.NaN, q.X2);
        }

        [TestMethod]
        public void Test_Two_Solution_B_Equal_To_Zero()
        {
            const double a = 5;
            const double b = 0;
            const double c = -125;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(5.0, q.X1);
            Assert.AreEqual(-5.0, q.X2);
        }

        [TestMethod]
        public void Test_No_solutions_B_Zero()
        {
            const double a = 5;
            const double b = 0;
            const double c = 3;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(double.NaN, q.X1);
            Assert.AreEqual(double.NaN, q.X2);
        }

        [TestMethod]
        public void Test_No_solutions_A_Zero_B_Zero()
        {
            const double a = 0;
            const double b = 0;
            const double c = -30;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(double.NaN, q.X1);
            Assert.AreEqual(double.NaN, q.X2);
        }

        [TestMethod]
        public void Test_No_solutions_All_Zero()
        {
            const double a = 0;
            const double b = 0;
            const double c = 0;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(double.NaN, q.X1);
            Assert.AreEqual(double.NaN, q.X2);
        }

        [TestMethod]
        public void Test_No_solutions()
        {
            const double a = 1;
            const double b = 2;
            const double c = 3;
            var q = new Quad.Quad(a, b, c);
            q.Calculate();
            Assert.AreEqual(double.NaN, q.X1);
            Assert.AreEqual(double.NaN, q.X2);
        }
    }
}
