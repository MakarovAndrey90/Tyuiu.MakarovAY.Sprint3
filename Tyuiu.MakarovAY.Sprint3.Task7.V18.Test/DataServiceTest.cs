using Tyuiu.MakarovAY.Sprint3.Task7.V18.Lib; 
namespace Tyuiu.MakarovAY.Sprint3.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService(); 
            int startValue = -5; int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] ValueWaitArray;
            ValueWaitArray = new double[len];
            ValueWaitArray[0] = 7.76;
            ValueWaitArray[1] = 7.36;
            ValueWaitArray[2] = 7.26;
            ValueWaitArray[3] = 7.9;
            ValueWaitArray[4] = 15.88;
            ValueWaitArray[5] = 2;
            ValueWaitArray[6] = 4.35;
            ValueWaitArray[7] = 5.63;
            ValueWaitArray[8] = 6.49;
            ValueWaitArray[9] = 6.49;
            ValueWaitArray[10] = 6.32;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(ValueWaitArray, res);


        }
    }
}
