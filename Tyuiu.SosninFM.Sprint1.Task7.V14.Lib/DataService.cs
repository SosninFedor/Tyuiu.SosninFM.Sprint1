
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SosninFM.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Round((Math.Pow(2,-5) + ((5*Math.Pow(5,2)) / (3*Math.Pow(5,3)) - Math.Cos(Math.Pow(5,2)) + Math.Sin(2*5*5))),4));
            return res;
        }
    }
}
