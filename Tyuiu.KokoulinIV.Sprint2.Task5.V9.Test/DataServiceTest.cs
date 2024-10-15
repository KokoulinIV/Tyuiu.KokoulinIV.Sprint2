using Tyuiu.KokoulinIV.Sprint2.Task5.V9.Lib;
namespace Tyuiu.KokoulinIV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1 январ€", ds.FindDateOfNextDay(1, 1));
        }
    }
}