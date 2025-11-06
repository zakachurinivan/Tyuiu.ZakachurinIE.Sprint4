using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZakachurinIE.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i==2 && array[i,j]>res )
                    {
                        res = array[i,j];
                    }
                }
            }
            return res;
        }
    }
}
