using Tyuiu.FilatovDK.Sprint4.Task5.V13.Lib;
namespace Tyuiu.FilatovDK.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 0, 0, 0, 0, -9 },
                                            { -7, 0, 0, 0, -9 },
                                            { 0, -7, -9, 0, -5 },
                                            { -7, -5, -7, -7, 0 },
                                            { 0, 0, 0, -7, -9 } };
            int[,] res = ds.Calculate(matrix);

            int[,] wait = new int[5, 5] { { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } }; ;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}