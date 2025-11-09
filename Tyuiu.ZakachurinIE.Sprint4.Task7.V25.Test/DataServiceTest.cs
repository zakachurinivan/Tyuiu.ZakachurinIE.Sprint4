using Tyuiu.ZakachurinIE.Sprint4.Task7.V25.Lib;


namespace Tyuiu.ZakachurinIE.Sprint4.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string s = new string("348561792486");
            int n = 4;
            int m = 3;
            var res = ds.Calculate(n,m,s);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}
