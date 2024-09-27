using Tyuiu.ShakhovDK.Sprint1.Task6.V2.Lib;

namespace Tyuiu.ShakhovDK.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string strTest = "dhveuwew";

            var res = ds.CheckHello(strTest);

            var wait = false;

            Assert.AreEqual(wait, res);

        }
    }
}