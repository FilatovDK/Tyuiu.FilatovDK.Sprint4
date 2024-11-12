﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FilatovDK.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length < 6);
            return mas.Length;
        }
    }
}
