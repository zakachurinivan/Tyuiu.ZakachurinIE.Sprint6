using Tyuiu.ZakachurinIE.Sprint6.Task2.V4.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);


            Assert.AreEqual(11, res.Length);


            Assert.AreEqual(-15.6, res[0]);
            Assert.AreEqual(38.41, res[10]);
        }
    }
}
