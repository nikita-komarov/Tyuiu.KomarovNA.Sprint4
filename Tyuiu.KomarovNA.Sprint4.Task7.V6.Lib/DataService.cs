using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KomarovNA.Sprint4.Task7.V6.Lib
{
    public class DataService : ISprint4Task7V6
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int indx = 0;
            for (int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j<matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(value[indx].ToString());
                    indx++;
                }
            }

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j]%2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }


            return sum;
        }
    }
}
