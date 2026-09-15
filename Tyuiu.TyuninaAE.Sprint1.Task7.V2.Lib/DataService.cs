using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TyuninaAE.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double z = (Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y);
            return Math.Round(z, 3);
        }
    }
}
