using Tiuiu.UsoltsevGP.Sprint3.Task5.V29.Lib;
namespace Tiuiu.UsoltsevGP.Sprint3.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 3;
            int stopValue1 = 1;
            int startValue2 = 10;
            int stopValue2 = 1;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}
