﻿
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SosninFM.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            var res = Convert.ToInt32(Math.Abs(Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)))));
            return res;
        }
    }
}
