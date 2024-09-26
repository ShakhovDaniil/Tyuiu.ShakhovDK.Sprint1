using Tyuiu.ShakhovDK.Sprint1.Task4.V30.Lib;

namespace Tyuiu.ShakhovDK.Sprint1.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;

            double y = 2;

            var wait = 9;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}