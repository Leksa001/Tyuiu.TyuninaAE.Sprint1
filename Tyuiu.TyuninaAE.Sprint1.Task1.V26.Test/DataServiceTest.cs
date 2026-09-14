using Tyuiu.TyuninaAE.Sprint1.Task1.V26.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 2);
            Assert.AreEqual(1.25, res);
        }
    }
}
