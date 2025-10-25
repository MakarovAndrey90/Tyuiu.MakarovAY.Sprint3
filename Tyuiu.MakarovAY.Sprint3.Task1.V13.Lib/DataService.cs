using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MakarovAY.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries + (Math.Pow(1 / (Math.Pow(value, multSeries)), -1));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
