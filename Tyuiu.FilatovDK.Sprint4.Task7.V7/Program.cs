﻿using Tyuiu.FilatovDK.Sprint4.Task7.V7.Lib;
namespace Tyuiu.FilatovDK.Sprint4.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 2;

            string str = "31415926";

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Филатов Д. К. | СМАРТб-24-1 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Филатов Денис Константинович | СМАРТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '31415926'.                           *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2 и подсчитайте количество               *");
            Console.WriteLine("* нечетных чисел в матрице.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Количество нечетных элементов: " + res);
            Console.ReadKey();

        }
    }
}
