using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakachurinIE.Sprint6.Task0.V17.Lib
{
    public class DataService : ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            double res = Math.Pow(Math.E, x) / x;
            return Math.Round(res, 3);

        }
    }
}
