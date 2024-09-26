using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KomarovNA.Sprint4.Task0.V9.Lib
{
    public class DataService : ISprint4Task0V9
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            foreach (int el in array)
            {
                if (el%2==0)
                {
                    sum += el;
                }
            }
            return sum;
        }
    }
}
