using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MakarovAY.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 1;
            do 
            {
                SumSeries = SumSeries * ((Math.Pow(value, 3) * startValue) + 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
