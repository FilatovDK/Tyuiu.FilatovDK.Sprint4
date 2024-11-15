﻿using Tyuiu.FilatovDK.Sprint4.Task0.V25.Lib;
namespace Tyuiu.FilatovDK.Sprint4.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Филатов Д. К. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Филатов Денис Константинович | СМАРТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму четных  *");
            Console.WriteLine("* элементов массива {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма четных элементов = " + ds.GetSumEvenArrEl(array));
            Console.ReadKey();
        }
    }
}
