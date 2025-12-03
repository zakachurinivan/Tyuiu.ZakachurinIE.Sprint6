using Tyuiu.ZakachurinIE.Sprint6.Task1.V5.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task1.V5.Test
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

            
            Assert.AreEqual(8.04, res[0]);  
            Assert.AreEqual(-8.88, res[10]); 
        }
    }
}
