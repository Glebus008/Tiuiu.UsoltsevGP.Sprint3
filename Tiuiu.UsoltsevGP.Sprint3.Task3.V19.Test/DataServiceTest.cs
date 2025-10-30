using Tiuiu.UsoltsevGP.Sprint3.Task3.V19.Lib;
namespace Tiuiu.UsoltsevGP.Sprint3.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string value = "sxxrrg x vfrx";
            char replaceable = 'x';
            char replacement = '2';

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);

            string wait = "s22rrg 2 vfr2";

            Assert.AreEqual(wait, res);
        }
    }
}
