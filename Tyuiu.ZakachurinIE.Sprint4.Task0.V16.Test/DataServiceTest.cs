using Tyuiu.ZakachurinIE.Sprint4.Task0.V16.Lib;

namespace Tyuiu.ZakachurinIE.Sprint4.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[] x = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = ds.GetMultEvenArrEl(x);
            Assert.AreEqual(3072, res);

        }
    }
}
