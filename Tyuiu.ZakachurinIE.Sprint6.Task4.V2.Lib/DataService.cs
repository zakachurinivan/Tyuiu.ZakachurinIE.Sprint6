using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakachurinIE.Sprint6.Task4.V2.Lib
{
    public class DataService : ISprint6Task4V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue)+1;
            valueArray = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round( Math.Cos(x)/(x-0.7) - Math.Sin(x)*12*x + 2 ,2);
                valueArray[cnt]= y;
                cnt++;
            }
            return valueArray;
        }
    }
}
