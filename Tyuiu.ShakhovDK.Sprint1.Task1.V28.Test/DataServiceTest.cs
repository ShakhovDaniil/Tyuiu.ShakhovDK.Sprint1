using Tyuiu.ShakhovDK.Sprint1.Task1.V28.Lib;

namespace Tyuiu.ShakhovDK.Sprint1.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);

        }
    }
}