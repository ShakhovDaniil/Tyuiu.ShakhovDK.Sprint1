using Tyuiu.ShakhovDK.Sprint1.Task7.V23.Lib;

namespace Tyuiu.ShakhovDK.Sprint1.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1, y = 2;

            var res = ds.Calculate(x, y);

            var wait = 1.265;

            Assert.AreEqual(wait, res);

        }
    }
}