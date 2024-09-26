using Tyuiu.ShakhovDK.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ShakhovDK.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 130985;

            int result = ds.Calculate(k);

            int wait = 9;

            Assert.AreEqual(wait, result);

        }
    }
}