using Newtonsoft.Json.Linq;
using Tyuiu.SosninFM.Sprint1.Task2.V13.Lib;

namespace Tyuiu.SosninFM.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMilesToKm(x);
            Math.Round(double, 3);
            Assert.AreEqual(3.2186, res);
            

        }
    }
}