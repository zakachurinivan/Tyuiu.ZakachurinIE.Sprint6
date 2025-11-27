using Tyuiu.ZakachurinIE.Sprint6.Task0.V17.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(6);
            Assert.AreEqual(6, res);    
        }
    }
}
