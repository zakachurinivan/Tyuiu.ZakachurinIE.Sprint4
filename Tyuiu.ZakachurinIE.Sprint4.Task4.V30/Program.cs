using Tyuiu.ZakachurinIE.Sprint4.Task4.V30.Lib;

namespace Tyuiu.ZakachurinIE.Sprint4.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт # 4 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Варинат #30                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) 
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(mtrx);
            for (int i = 0;i < rows;i++)
            {
                for (int j = 0; i < columns; j++)
                {
                    Console.WriteLine(res[i, j]);
                }    
            }

        }
    }
}