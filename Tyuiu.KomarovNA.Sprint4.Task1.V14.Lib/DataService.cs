using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KomarovNA.Sprint4.Task1.V14.Lib
{
    public class DataService : ISprint4Task1V14
    {
        public int Calculate(int[] array)
        {
            return array.Where(el => el%2!=0).Sum();
        }
    }
}
