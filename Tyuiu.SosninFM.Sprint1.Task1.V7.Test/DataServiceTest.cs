
using Tyuiu.SosninFM.Sprint1.Task1.V7.Lib;

namespace Tyuiu.SosninFM.Sprint1.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.6666666666666667, res);

        }
    }
}