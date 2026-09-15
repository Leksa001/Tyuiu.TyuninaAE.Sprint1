using Tyuiu.TyuninaAE.Sprint1.Task5.V7.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int res = ds.AngleToHoursMinutes(100.5);
            Assert.AreEqual(3, res);
        }
    }
}
