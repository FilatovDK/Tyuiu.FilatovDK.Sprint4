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
            int[,] matrix = new int[5, 5] { { 4, 7, 4, 5, 4 },
                                            { 4, 4, 5, 6, 7 },
                                            { 7, 5, 6, 6, 6 },
                                            { 6, 7, 6, 6, 4 },
                                            { 5, 6, 6, 6, 5 } };

            int[,] wait = new int[5, 5] {   { 4, 0, 4, 0, 4 },
                                            { 4, 4, 0, 6, 0 },
                                            { 0, 0, 6, 6, 6 },
                                            { 6, 0, 6, 6, 4 },
                                            { 0, 6, 6, 6, 0 } };

            var rez = ds.Calculate(matrix);

            CollectionAssert.AreEqual(wait, rez);
        }
    }
}