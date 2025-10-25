using Tyuiu.MakarovAY.Sprint3.Task1.V13.Lib;
namespace Tyuiu.MakarovAY.Sprint3.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double Value = 1.2; 
            int startValue = 1; int stopValue = 7;

            double res = ds.GetMultiplySeries(Value, startValue, stopValue);
            double wait = 104.946;
            Assert.AreEqual(wait, res);
        }
    }
}
