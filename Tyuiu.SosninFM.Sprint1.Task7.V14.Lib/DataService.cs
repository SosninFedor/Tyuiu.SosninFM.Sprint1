
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SosninFM.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Round((Math.Pow(2,-1) + ((5*Math.Pow(1,2)) / (3*Math.Pow(1,2)) - Math.Cos(Math.Pow(1,2)) + Math.Sin(2*1*2))),3));
            return res;

        }
    }
}
