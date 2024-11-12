using Tyuiu.FilatovDK.Sprint4.Task2.V28.Lib;
namespace Tyuiu.FilatovDK.Sprint4.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                DataService ds = new DataService();

                int[] array = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };
                int res = ds.Calculate(array);
                int wait = 21;
                Assert.AreEqual(wait, res);
            }
        }
    }
}