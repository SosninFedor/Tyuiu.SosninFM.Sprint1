
using Tyuiu.SosninFM.Sprint1.Task5.V1.Lib;

namespace Tyuiu.SosninFM.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 1;

            double y1 = 1;
            
            double x2 = 2;
            
            double y2 = 2;
            
            double wait = 1;
            
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
    }
}