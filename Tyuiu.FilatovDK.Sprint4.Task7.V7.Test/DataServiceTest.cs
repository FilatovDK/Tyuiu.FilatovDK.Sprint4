using Tyuiu.FilatovDK.Sprint4.Task7.V7.Lib;
namespace Tyuiu.FilatovDK.Sprint4.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int colums = 2;
            int[,] mtrx = new int[rows, colums];
            string str = "31415926";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, colums, str);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}