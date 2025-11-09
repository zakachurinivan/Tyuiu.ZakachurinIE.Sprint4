using Tyuiu.ZakachurinIE.Sprint4.Task6.V26.Lib;

namespace Tyuiu.ZakachurinIE.Sprint4.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] city = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            var res = ds.Calculate(city);
            string[] wait = new string[] { "Тюмень", "Тамбов" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
