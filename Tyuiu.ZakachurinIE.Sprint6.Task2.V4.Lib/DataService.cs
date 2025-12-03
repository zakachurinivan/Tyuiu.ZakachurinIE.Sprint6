using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakachurinIE.Sprint6.Task2.V4.Lib
{
    public class DataService : ISprint6Task2V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            double y;
            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((5*x + 2.5)/(Math.Sin(x) + 2) +(2*x) + 2, 2);
                valueArray[k] = y;
                k++;
            }
            return valueArray;
        }
    }
    
}
