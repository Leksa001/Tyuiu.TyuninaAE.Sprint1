using Tyuiu.TyuninaAE.Sprint1.Task6.V8.Lib;

namespace Tyuiu.TyuninaAE.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd("Привет Мир");
            string wait = "риветП ирМ";
            Assert.AreEqual(wait, res);
        }
    }
}
