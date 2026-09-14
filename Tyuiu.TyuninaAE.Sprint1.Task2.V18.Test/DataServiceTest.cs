using Tyuiu.TyuninaAE.Sprint1.Task2.V18.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int res = ds.CalculateSideSquareParallelepiped(2, 3, 4);
            Assert.AreEqual(40, res);
        }
    }
}
