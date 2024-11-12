using Tyuiu.FilatovDK.Sprint4.Task3.V27.Lib;
namespace Tyuiu.FilatovDK.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 3 до 7.              *");
            Console.WriteLine("* Подсчитайте количество четных элементов во всем массиве.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                       { 4, 3, 5, 5, 3 }                                 *");
            Console.WriteLine("*                       { 6, 7, 4, 4, 3 }                                 *");
            Console.WriteLine("*                       { 3, 3, 7, 3, 6 }                                 *");
            Console.WriteLine("*                       { 3, 4, 3, 7, 7 }                                 *");
            Console.WriteLine("*                       { 3, 5, 6, 3, 6 }                                 *");
            Console.WriteLine("***************************************************************************");

            int[,] array = { { 4, 3, 5, 5, 3 },
                             { 6, 7, 4, 4, 3},
                             { 3, 3, 7, 3, 6},
                             { 3, 4, 3, 7, 7 },
                             { 3, 5, 6, 3, 6 } };



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int z = ds.Calculate(array);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}