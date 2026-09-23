using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TyuninaAE.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Cos(x) - y) / Math.Exp(y + x);
            return Math.Round(res, 3, MidpointRounding.AwayFromZero);
        }
    }
}
