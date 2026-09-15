using Tyuiu.TyuninaAE.Sprint1.Task7.V2.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 2);
            double wait = 2.519;
            Assert.AreEqual(wait, res);
        }
    }
}
