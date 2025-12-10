using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZelenovaIV.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {
            int r1 = array.GetUpperBound(0) + 1;
            int r2 = array.Length / r1;
            int m = 9;
            for (int i = 0; i < r1; i++)
            {
                for (int j = 4; j < r2; j++)
                {
                    if (array[i, j] < m)
                    {
                        m = array[i, j];
                    }
                }
            }
            return m;
        }
    }
}