
using Tyuiu.SosninFM.Sprint1.Task4.V18.Lib;

namespace Tyuiu.SosninFM.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.14;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}