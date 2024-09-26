﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KomarovNA.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V14
    {
        public string[] Calculate(string[] array)
        {
            return array.Where(str => str.Length>3).ToArray();
        }
    }
}
