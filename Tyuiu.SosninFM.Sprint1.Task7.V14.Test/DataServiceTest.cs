
using Tyuiu.SosninFM.Sprint1.Task7.V14.Lib;

namespace Tyuiu.SosninFM.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double wait = -0.889;  
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}