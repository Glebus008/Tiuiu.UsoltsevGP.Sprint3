using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tiuiu.UsoltsevGP.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                if (Math.Abs(denominator) > 0)
                {
                    y = Math.Round(((2 * x + 6) / denominator - 3), 2);
                }
                else
                {
                    y = 0;
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
