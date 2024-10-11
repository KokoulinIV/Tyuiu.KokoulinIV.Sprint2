using Tyuiu.KokoulinIV.Sprint2.Task3.V7.Lib;
namespace Tyuiu.KokoulinIV.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wail = 50;
            Assert.AreEqual(wail, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wail = 0.75;
            Assert.AreEqual(wail, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wail = 64;
            Assert.AreEqual(wail, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -12;
            double res = ds.Calculate(x);
            double wail = 20736.25;
            Assert.AreEqual(wail, res);
        }
    }
}