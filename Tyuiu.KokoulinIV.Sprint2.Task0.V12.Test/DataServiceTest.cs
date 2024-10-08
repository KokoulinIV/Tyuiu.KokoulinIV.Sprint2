using Tyuiu.KokoulinIV.Sprint2.Task0.V12.Lib;
namespace Tyuiu.KokoulinIV.Sprint2.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1095;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wail = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(res, wail);
        }
    }
}