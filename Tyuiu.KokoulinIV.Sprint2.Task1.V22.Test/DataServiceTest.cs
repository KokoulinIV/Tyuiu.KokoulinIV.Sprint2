using Tyuiu.KokoulinIV.Sprint2.Task1.V22.Lib;
namespace Tyuiu.KokoulinIV.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wail = new bool[6] { true, true, true, false, false, false };
            CollectionAssert.AreEqual(res, wail);
           











            //при a = 324, b = 696, c = 254, d = 155
        }
    }
}