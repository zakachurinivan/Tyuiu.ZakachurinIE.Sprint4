using Tyuiu.ZakachurinIE.Sprint4.Task5.V5.Lib;

namespace Tyuiu.ZakachurinIE.Sprint4.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] x = new int[5, 5] { {-1, -1, -1, 6, 5 }, { 0, 0, 0, 0, 0 }, { 0,0,0,0,0}, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int res = ds.Calculate(x);
            Assert.AreEqual(11, res);
        }
    }
}
