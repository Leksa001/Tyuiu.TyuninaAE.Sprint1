using Tyuiu.TyuninaAE.Sprint1.Task4.V26.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, -1);
            Assert.AreEqual(-0.215, res);
        }
    }
}
