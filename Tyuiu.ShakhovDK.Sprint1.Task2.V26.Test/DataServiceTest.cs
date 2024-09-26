using Tyuiu.ShakhovDK.Sprint1.Task2.V26.Lib;

namespace Tyuiu.ShakhovDK.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;

            int y = 4;

            var res = ds.CalculateMinutesSinceStart(x, y);

            Assert.AreEqual(184, res);

        }
    }
}