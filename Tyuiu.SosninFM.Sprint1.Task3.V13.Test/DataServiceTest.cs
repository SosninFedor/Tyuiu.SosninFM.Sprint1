
using Tyuiu.SosninFM.Sprint1.Task3.V13.Lib;

namespace Tyuiu.SosninFM.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 123;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(6, res);
        }
    }
}