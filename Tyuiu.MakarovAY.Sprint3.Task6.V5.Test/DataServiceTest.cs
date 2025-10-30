using System.Transactions;
using Tyuiu.MakarovAY.Sprint3.Task6.V5.Lib;
namespace Tyuiu.MakarovAY.Sprint3.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 15; int stopValue = 22;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 242;
            Assert.AreEqual(wait, res); 
        }
    }
}
